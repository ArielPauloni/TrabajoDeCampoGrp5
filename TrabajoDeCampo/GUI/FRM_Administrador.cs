using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SL;
using BLL;
using BE;

namespace GUI
{
    public partial class FRM_Administrador : Form
    {
        private UsuarioBE usuario = new UsuarioBE();
        private AutorizacionSL gestorAutorizacion = new AutorizacionSL();
        private TipoUsuarioBLL gestorTipoUsuario = new TipoUsuarioBLL();
        private PermisoSL gestorPermiso = new PermisoSL();

        public FRM_Administrador(UsuarioBE usuarioAutenticado)
        {
            InitializeComponent();
            usuario = usuarioAutenticado;
        }

        private void FRM_Administrador_Load(object sender, EventArgs e)
        {
            lblHolaAdmin.Text = "Hola " + usuario.ToString();

            if (gestorAutorizacion.ValidarPermisoUsuario(new PermisoBE("Gestionar Permisos"), usuario))
            {
                grpPermisos.Visible = true;
                EnlazarArbolPermisos();
                EnlazarArbolTipoUsuarios();
            }
            else { grpPermisos.Visible = false; }
        }

        private void EnlazarArbolPermisos()
        {
            //estos NO son permisos BE, estos son componentes... porque puede ser nodo u hoja
            List<PermisoBE> permisos = gestorPermiso.ListarPermisos();

            trvPermisos.Nodes.Clear();
            trvPermisos.BeginUpdate();

            foreach (PermisoBE permiso in permisos)
            {
                trvPermisos.Nodes.Add(permiso.ToString());
            }

            trvPermisos.EndUpdate();
        }

        private void EnlazarArbolTipoUsuarios()
        {
            List<TipoUsuarioBE> listaTipoUsuario = gestorTipoUsuario.Listar();

            trvTiposUsuario.Nodes.Clear();
            trvTiposUsuario.BeginUpdate();

            foreach (TipoUsuarioBE tp in listaTipoUsuario)
            {
                trvTiposUsuario.Nodes.Add(tp.ToString());
            }

            trvTiposUsuario.EndUpdate();
        }

        private void btnAgregarPermiso_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPermiso.Text))
            {
                PermisoBE permiso = new PermisoBE(txtPermiso.Text);
                int i = gestorPermiso.InsertarPermiso(permiso);
                EnlazarArbolPermisos();
                txtPermiso.Text = string.Empty;
            }
        }

        private void btnRelPadreHijo_Click(object sender, EventArgs e)
        {

        }
    }
}

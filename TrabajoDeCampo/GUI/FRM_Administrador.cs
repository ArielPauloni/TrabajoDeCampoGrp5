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
        private UsuarioBE usuarioAutenticado = new UsuarioBE();
        private AutorizacionSL gestorAutorizacion = new AutorizacionSL();
        private TipoUsuarioBLL gestorTipoUsuario = new TipoUsuarioBLL();
        private PermisoSL gestorPermiso = new PermisoSL();
        private PermisoBE permisoPadre = new PermisoBE();
        private PermisoBE permisoHijo = new PermisoBE();

        public FRM_Administrador(UsuarioBE usuario)
        {
            InitializeComponent();
            usuarioAutenticado = usuario;
        }

        private void FRM_Administrador_Load(object sender, EventArgs e)
        {
            lblHolaAdmin.Text = "Hola " + usuarioAutenticado.ToString();
            RefreshForm(true);
        }

        #region Eventos Comunes

        private void RefreshForm(Boolean necesitoEnlazar)
        {
            if (gestorAutorizacion.ValidarPermisoUsuario(new PermisoBE("Gestionar Permisos"), usuarioAutenticado))
            {
                grpPermisos.Visible = true;
                if (necesitoEnlazar) { EnlazarArbolPermisos(); }
                HabilitarEdicionPermisos(chkEditPermisos.Checked);
            }
            else { grpPermisos.Visible = false; }
            if (gestorAutorizacion.ValidarPermisoUsuario(new PermisoBE("Asignar Permisos"), usuarioAutenticado))
            {
                grpTiposDeUsuario.Visible = true;
                btnAsignarPermiso.Visible = true;
                cboTipoUsuarios.DataSource = gestorTipoUsuario.Listar();
                if (necesitoEnlazar) { EnlazarArbolPermisosPorTipoUsuario((TipoUsuarioBE)cboTipoUsuarios.SelectedItem); }
            }
            else { grpTiposDeUsuario.Visible = false; btnAsignarPermiso.Visible = false; }
            if (gestorAutorizacion.ValidarPermisoUsuario(new PermisoBE("Quitar Permisos"), usuarioAutenticado))
            { btnQuitarPermiso.Visible = true; }
            else { btnQuitarPermiso.Visible = false; }
        }

        private void EnlazarArbolPermisos()
        {
            List<SL.PatronComposite.ComponentPermiso> components = gestorPermiso.ListarPermisosArbol(usuarioAutenticado);
            if (components != null)
            {
                trvPermisos.Nodes.Clear();
                trvPermisos.BeginUpdate();

                foreach (SL.PatronComposite.ComponentPermiso component in components)
                {
                    component.Mostrar(trvPermisos.Nodes);
                }
                trvPermisos.EndUpdate();
                trvPermisos.ExpandAll();
            }
            else
            {
                //Sin permisos:
                MessageBox.Show("Usted no posee permisos para esta acción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EnlazarArbolPermisosPorTipoUsuario(TipoUsuarioBE tipoUsuario)
        {
            List<SL.PatronComposite.ComponentPermiso> components = gestorPermiso.ListarPermisosPorTipoUsuario(tipoUsuario, usuarioAutenticado);
            if (components != null)
            {
                trvTiposUsuario.Nodes.Clear();
                trvTiposUsuario.BeginUpdate();

                foreach (SL.PatronComposite.ComponentPermiso component in components)
                {
                    component.Mostrar(trvTiposUsuario.Nodes);
                }
                trvTiposUsuario.EndUpdate();
                trvTiposUsuario.ExpandAll();
            }
            else
            {
                //Sin permisos:
                MessageBox.Show("Usted no posee permisos para esta acción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void HabilitarEdicionPermisos(Boolean enabled)
        {
            if (enabled) { this.Size = new Size(940, 530); }
            else { this.Size = new Size(940, 370); }
            grpEditarPermisos.Visible = enabled;
            btnAgregarPermiso.Enabled = enabled;
            txtPermiso.Enabled = enabled;
            btnRelPadreHijo.Enabled = enabled;
            txtPadre.Enabled = enabled;
            txtHijo.Enabled = enabled;
            btnLimpiarSeleccion.Enabled = enabled;
            btnRomperRelPadreHijo.Enabled = enabled;
        }
        #endregion

        #region Gestion Permisos_Permisos
        private void chkEditPermisos_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarEdicionPermisos(chkEditPermisos.Checked);
        }

        private void btnAgregarPermiso_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPermiso.Text))
            {
                PermisoBE permiso = new PermisoBE(txtPermiso.Text);
                if (gestorPermiso.InsertarPermiso(permiso, usuarioAutenticado) < 0)
                {
                    //Sin permisos:
                    MessageBox.Show("Usted no posee permisos para esta acción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    EnlazarArbolPermisos();
                    txtPermiso.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre de permiso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRelPadreHijo_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtPadre.Text)) && (!string.IsNullOrWhiteSpace(txtHijo.Text)))
            {
                if (gestorPermiso.RelacionarPermisos(permisoPadre, permisoHijo, usuarioAutenticado) < 0)
                {
                    //Sin permisos:
                    MessageBox.Show("Usted no posee permisos para esta acción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtPadre.Text = string.Empty;
                    txtHijo.Text = string.Empty;
                    EnlazarArbolPermisos();
                    EnlazarArbolPermisosPorTipoUsuario((TipoUsuarioBE)cboTipoUsuarios.SelectedItem);
                    RefreshForm(false);
                }
            }
        }

        private void trvPermisos_DoubleClick(object sender, EventArgs e)
        {
            trvPermisos.SelectedNode.ExpandAll();
            if (chkEditPermisos.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtPadre.Text))
                {
                    permisoPadre.CodPermiso = int.Parse(trvPermisos.SelectedNode.Name);
                    permisoPadre.DescripcionPermiso = trvPermisos.SelectedNode.Text;
                    txtPadre.Text = trvPermisos.SelectedNode.Text;
                }
                else if (string.IsNullOrWhiteSpace(txtHijo.Text))
                {
                    if (permisoPadre.CodPermiso == int.Parse(trvPermisos.SelectedNode.Name))
                    { MessageBox.Show("Permiso ya agregado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    else
                    {
                        permisoHijo.CodPermiso = int.Parse(trvPermisos.SelectedNode.Name);
                        permisoHijo.DescripcionPermiso = trvPermisos.SelectedNode.Text;
                        txtHijo.Text = trvPermisos.SelectedNode.Text;
                    }
                }
            }
        }

        private void btnLimpiarSeleccion_Click(object sender, EventArgs e)
        {
            txtPadre.Text = string.Empty;
            txtHijo.Text = string.Empty;
        }

        private void btnRomperRelPadreHijo_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtPadre.Text)) && (!string.IsNullOrWhiteSpace(txtHijo.Text)))
            {
                if (gestorPermiso.QuitarRelacionPermisos(permisoPadre, permisoHijo, usuarioAutenticado) < 0)
                {
                    //Sin permisos:
                    MessageBox.Show("Usted no posee permisos para esta acción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtPadre.Text = string.Empty;
                    txtHijo.Text = string.Empty;
                    EnlazarArbolPermisos();
                    EnlazarArbolPermisosPorTipoUsuario((TipoUsuarioBE)cboTipoUsuarios.SelectedItem);
                    RefreshForm(false);
                }
            }
        }
        #endregion

        #region Gestion Tipos Usuario
        private void cboTipoUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnlazarArbolPermisosPorTipoUsuario((TipoUsuarioBE)cboTipoUsuarios.SelectedItem);
        }

        private void btnAsignarPermiso_Click(object sender, EventArgs e)
        {
            if (gestorAutorizacion.ValidarPermisoUsuario(new PermisoBE("Asignar Permisos"), usuarioAutenticado))
            {
                foreach (TreeNode nodo in trvPermisos.Nodes)
                {
                    PermisoTipoUsuario(nodo, false);
                }
                EnlazarArbolPermisosPorTipoUsuario((TipoUsuarioBE)cboTipoUsuarios.SelectedItem);
                RefreshForm(false);
            }
            else { MessageBox.Show("Usted no posee permisos para esta acción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void btnQuitarPermiso_Click(object sender, EventArgs e)
        {
            if (gestorAutorizacion.ValidarPermisoUsuario(new PermisoBE("Quitar Permisos"), usuarioAutenticado))
            {
                foreach (TreeNode nodo in trvTiposUsuario.Nodes)
                {
                    PermisoTipoUsuario(nodo, true);
                }
                EnlazarArbolPermisosPorTipoUsuario((TipoUsuarioBE)cboTipoUsuarios.SelectedItem);
                RefreshForm(false);
            }
            else { MessageBox.Show("Usted no posee permisos para esta acción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void PermisoTipoUsuario(TreeNode treeNode, Boolean eliminar)
        {
            if (treeNode.Checked)
            {
                PermisoBE permiso = new PermisoBE();
                permiso.CodPermiso = int.Parse(treeNode.Name);
                permiso.DescripcionPermiso = treeNode.Text;
                if (eliminar)
                {
                    if ((gestorPermiso.EliminarPermisoPorTipoUsuario((TipoUsuarioBE)cboTipoUsuarios.SelectedItem, permiso, usuarioAutenticado)) < 0)
                    {
                        //Sin permisos:
                        MessageBox.Show("Usted no posee permisos para esta acción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if ((gestorPermiso.InsertarPermisoPorTipoUsuario((TipoUsuarioBE)cboTipoUsuarios.SelectedItem, permiso, usuarioAutenticado)) < 0)
                    {
                        //Sin permisos:
                        MessageBox.Show("Usted no posee permisos para esta acción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            //TODO: Revisar esta recursividad...
            foreach (TreeNode tn in treeNode.Nodes)
            {
                PermisoTipoUsuario(tn, eliminar);
            }
        }
        #endregion

        #region detalles Formulario
        private void txtPadre_MouseEnter(object sender, EventArgs e)
        {
            tooltipRelacionar.Show("Doble click al permiso que desee seleccionar", txtPadre);
        }

        private void txtPadre_MouseLeave(object sender, EventArgs e)
        {
            tooltipRelacionar.Hide(txtPadre);
        }

        private void txtHijo_MouseEnter(object sender, EventArgs e)
        {
            tooltipRelacionar.Show("Doble click al permiso que desee seleccionar", txtHijo);
        }

        private void txtHijo_MouseLeave(object sender, EventArgs e)
        {
            tooltipRelacionar.Hide(txtHijo);
        }
        #endregion
    }
}

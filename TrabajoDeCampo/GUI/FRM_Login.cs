using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using SL;
using BE;

namespace GUI
{
    public partial class FRM_Login : Form
    {
        private UsuarioBLL gestorUsuarioBLL = new UsuarioBLL();
        private LoginSL gestorLogin = new LoginSL();
        private BitacoraSL gestorBitacora = new BitacoraSL();
        private UsuarioBE usuarioAutenticado = new UsuarioBE();

        public FRM_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtUsuarioMail.Text)) && (!string.IsNullOrWhiteSpace(txtUsuarioClave.Text)))
            {
                UsuarioBE usuario = new UsuarioBE();

                usuario.Mail = txtUsuarioMail.Text;
                usuario.Contraseña = txtUsuarioClave.Text;
                try
                {
                    usuarioAutenticado = gestorLogin.ObtenerUsuarioAutenticado(usuario);
                }
                catch (SL.UsuarioModificadoException ex)
                {
                    MessageBox.Show(ex.Message);
                    usuarioAutenticado = null;
                }

                if (usuarioAutenticado != null)
                {
                    SesionSL.Instance.Login(usuarioAutenticado);
                    BitacoraBE bitacoraBE = new BitacoraBE();
                    bitacoraBE.Cod_Usuario = usuarioAutenticado.Cod_Usuario;
                    bitacoraBE.Cod_Evento = (short)EventosBE.Eventos.Login;
                    gestorBitacora.Insertar(bitacoraBE, usuarioAutenticado);

                    switch (usuarioAutenticado.Cod_Tipo)
                    {
                        case 1:
                            //Abrir lo correspondiente al cliente
                            FRM_Cliente frmCliente = new FRM_Cliente(usuarioAutenticado);
                            frmCliente.ShowDialog();
                            break;
                        case 2:
                            //Abrir lo correspondiente al administrador
                            FRM_Administrador frmAdmin = new FRM_Administrador(usuarioAutenticado);
                            frmAdmin.ShowDialog();
                            break;
                        case 3:
                            //Abrir lo correspondiente al Web Master
                            FRM_WebMaster frmWebMaster = new FRM_WebMaster(usuarioAutenticado);
                            frmWebMaster.ShowDialog();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }
    }
}

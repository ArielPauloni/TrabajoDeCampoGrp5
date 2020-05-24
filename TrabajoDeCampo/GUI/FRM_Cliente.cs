using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace GUI
{
    public partial class FRM_Cliente : Form
    {
        private ClienteBE cliente = new ClienteBE();
        private UsuarioBE usuario = new UsuarioBE();
        private ClienteBLL gestorCliente = new ClienteBLL();
        
        public FRM_Cliente(UsuarioBE usuarioAutenticado)
        {
            InitializeComponent();
            //obtengo la especialización del cliente:
            usuario = usuarioAutenticado;
            cliente.Cod_Usuario = usuarioAutenticado.Cod_Usuario;
            cliente = gestorCliente.ObtenerCliente(cliente);
            gestorCliente.ObtenerCliente(cliente);
        }

        private void FRM_Cliente_Load(object sender, EventArgs e)
        {
            lblHolaCliente.Text = "Hola " + cliente.ToString();

            if (cliente.TipoCliente == "PREMIUM")
            {
                btnReservar.Visible = true;
            }
            else if (cliente.TipoCliente == "STANDARD")
            {
                btnReservar.Visible = false;
            }
        }
    }
}

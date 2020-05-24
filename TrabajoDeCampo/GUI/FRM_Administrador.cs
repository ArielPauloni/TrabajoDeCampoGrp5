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
using BE;

namespace GUI
{
    public partial class FRM_Administrador : Form
    {
        private UsuarioBE usuario = new UsuarioBE();

        public FRM_Administrador(UsuarioBE usuarioAutenticado)
        {
            InitializeComponent();
            usuario = usuarioAutenticado;
        }

        private void FRM_Administrador_Load(object sender, EventArgs e)
        {
            lblHolaAdmin.Text = "Hola " + usuario.ToString();
        }
    }
}

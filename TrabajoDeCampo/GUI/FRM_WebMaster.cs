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

namespace GUI
{
    public partial class FRM_WebMaster : Form
    {
        private UsuarioBE usuario = new UsuarioBE();

        public FRM_WebMaster(UsuarioBE usuarioAutenticado)
        {
            InitializeComponent();
            usuario = usuarioAutenticado;
        }

        private void FRM_WebMaster_Load(object sender, EventArgs e)
        {
            lblHolaWebMaster.Text = "Hola " + usuario.ToString();
        }
    }
}

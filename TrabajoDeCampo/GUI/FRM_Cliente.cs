﻿using System;
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
using SL;

namespace GUI
{
    public partial class FRM_Cliente : Form
    {
        private UsuarioBE usuario = new UsuarioBE();
        private AutorizacionSL gestorAutorizacion = new AutorizacionSL();
        
        public FRM_Cliente(UsuarioBE usuarioAutenticado)
        {
            InitializeComponent();
            //obtengo la especialización del cliente:
            usuario = usuarioAutenticado;
        }

        private void FRM_Cliente_Load(object sender, EventArgs e)
        {
            lblHolaCliente.Text = "Hola " + usuario.ToString();

            if (gestorAutorizacion.ValidarPermisoUsuario(new PermisoBE("Reservar"),usuario))
            {
                btnReservar.Visible = true;
            }
        }
    }
}

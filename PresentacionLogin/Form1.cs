using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace PresentacionLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            
            string usuario = txtUsuario.Text;
            string contrasenna = txtContrasenna.Text.ToString();

            if (Procesos.validarAcceso(usuario,contrasenna) == true)
            {
                MessageBox.Show("¡Bienvenido!");
            }else MessageBox.Show("Usuario/Contraseña incorrecto o no se encuentra registrado.");

            limpiarEspacios();
        }

        private void limpiarEspacios()
        {
            txtUsuario.Text = "";
            txtContrasenna.Text = "";
        }

    }
}

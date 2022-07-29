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
    public partial class frmLogin : Form
    {
        
        public frmLogin() 
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            
            string usuario = txtUsuario.Text;
            string contrasenna = txtContrasenna.Text.ToString();
            (bool acceder, string cargo) = Procesos.validarAcceso(usuario, contrasenna);

            if ( acceder== true && cargo.Equals("A"))
            {
                MessageBox.Show("¡Bienvenido!");
                frmMantenimiento ofmrMantenimiento = new frmMantenimiento();
                ofmrMantenimiento.Visible = true;
                this.Hide();
                
            }
            else MessageBox.Show("Usuario/Contraseña incorrecto o no se encuentra registrado.");

            limpiarEspacios();
        }

        private void limpiarEspacios()
        {
            txtUsuario.Text = "";
            txtContrasenna.Text = "";
        }

    }
}

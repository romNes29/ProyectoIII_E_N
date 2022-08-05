using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionLogin
{
    public partial class frmCRUDTours : Form
    {
        static frmMantenimiento ofrmMantenimiento = new frmMantenimiento();
        public frmCRUDTours()
        {
            InitializeComponent();
        }

        private void frmCRUDTours_Load(object sender, EventArgs e)
        {

        }



        private void btnInicioM_Click_1(object sender, EventArgs e)
        {
            frmMantenimiento frmMantenimiento = new frmMantenimiento();
            frmMantenimiento.Visible = true;
            this.Hide();
        }

        private void timFechaHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void frmCRUDTours_FormClosed(object sender, FormClosedEventArgs e)
        {
            ofrmMantenimiento.Visible = true;
            this.Hide();
        }
    }
}

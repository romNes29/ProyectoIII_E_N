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
    public partial class frmReserva : Form
    {
        public frmReserva()
        {
            InitializeComponent();
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            frmFacturacion ofrmFacturacion = new frmFacturacion();
            ofrmFacturacion.Visible = true;
        }
    }
}

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
    public partial class frmMantenimiento : Form
    {
        public frmMantenimiento()
        {
            InitializeComponent();

        }

        private void frmMantenimiento_Load(object sender, EventArgs e)
        {
            deshabilitaSubMenues();
            pbxMantenimiento.SendToBack();

        }

        private void timFechaHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            deshabilitaSubMenues();
            pnlClientes.Visible = true;
        }

        private void btnTours_Click(object sender, EventArgs e)
        {
            deshabilitaSubMenues();
            pnlTours.Visible = true;
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            deshabilitaSubMenues();
            pnlCategorias.Visible = true;

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            deshabilitaSubMenues();
            pnlCompras.Visible = true;
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            deshabilitaSubMenues();
            pnlFacturas.Visible = true;
        }

        private void btnLugares_Click(object sender, EventArgs e)
        {
            deshabilitaSubMenues();
            pnlLugares.Visible = true;
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            deshabilitaSubMenues();
            pnlReservas.Visible = true;
        }
        private void deshabilitaSubMenues()
        {
            pnlClientes.Visible = false;
            pnlTours.Visible = false;
            pnlCategorias.Visible = false;
            pnlCompras.Visible = false;
            pnlFacturas.Visible = false;
            pnlLugares.Visible = false;
            pnlReservas.Visible = false;

            
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            deshabilitaSubMenues();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            deshabilitaSubMenues();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            deshabilitaSubMenues();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            deshabilitaSubMenues();
        }

        private void lblHora_MouseClick(object sender, MouseEventArgs e)
        {
            deshabilitaSubMenues();
        }

        private void lblFecha_MouseClick(object sender, MouseEventArgs e)
        {
            deshabilitaSubMenues();
        }

        //Acciones de Botones CRUD clientes
        private void btnCrearC_Click(object sender, EventArgs e)
        {
            frmCRUDClientes oCRUDClientes = new frmCRUDClientes();
            oCRUDClientes.Visible = true;
            deshabilitaSubMenues();
            this.Hide();
        }
        
        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            frmCRUDClientes oCRUDClientes = new frmCRUDClientes();
            oCRUDClientes.Visible = true;
            deshabilitaSubMenues();
            this.Hide();
        }

        private void btnModificarC_Click(object sender, EventArgs e)
        {
            frmCRUDClientes oCRUDClientes = new frmCRUDClientes();
            oCRUDClientes.Visible = true;
            deshabilitaSubMenues();
            this.Hide();
        }

        private void btnBuscarC_Click(object sender, EventArgs e)
        {
            frmCRUDClientes oCRUDClientes = new frmCRUDClientes();
            oCRUDClientes.Visible = true;
            deshabilitaSubMenues();
            this.Hide();
        }

        //Acciones de Botones CRUD tours
        private void btnCrearTour_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarTou_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarTour_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarTour_Click(object sender, EventArgs e)
        {

        }
        //Acciones de Botones CRUD categorias
        private void btnCrearCate_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarCate_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarCate_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCate_Click(object sender, EventArgs e)
        {

        }
        //Acciones de Botones CRUD compras
        private void btnCrearCompra_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarCompra_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarCompra_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCompra_Click(object sender, EventArgs e)
        {

        }
        //Acciones de Botones CRUD facturas
        private void btnCrearFactu_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarFactu_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarFactu_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarFactu_Click(object sender, EventArgs e)
        {

        }
        //Acciones de Botones CRUD lugares
        private void btnCrearLugar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarLugar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarLugar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarLugar_Click(object sender, EventArgs e)
        {

        }
        //Acciones de Botones CRUD reservas
        private void btnCrearRe_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarRe_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarRe_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarRe_Click(object sender, EventArgs e)
        {

        }

        private void frmMantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

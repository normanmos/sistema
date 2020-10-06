using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatamDS
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void AdministrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.factura.AdministrarFactura administrar = new formularios.factura.AdministrarFactura();
            administrar.Show();
        }

        private void ConsultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.factura.ConsultarFactura consultar = new formularios.factura.ConsultarFactura();
            consultar.Show();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.cliente.ConsultarCliente consultar = new formularios.cliente.ConsultarCliente();
            consultar.Show();
        }

        private void FacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void SesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sRIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void facturaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void notasDeEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contabilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.factura.ConsultarFactura consultar = new formularios.factura.ConsultarFactura();
            consultar.Show();
        }

        private void notasDeEntregaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

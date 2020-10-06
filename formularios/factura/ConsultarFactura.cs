using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LatamDS.formularios.factura
{
    public partial class ConsultarFactura : Form
    {
        public ConsultarFactura()
        {
            InitializeComponent();
        }
        void ConsultaFactura(DataGridView grid)
        {
            clases.Conexion conexion = new clases.Conexion();
            try
            {

                conexion.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand("PROC_CONSULTAR_FACTURA", conexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid.DataSource = dt;
                conexion.CerrarConexion();
                grid.Columns[0].HeaderText = "N. Factura";
                grid.Columns[1].HeaderText = "RUC";
                grid.Columns[2].HeaderText = "Razón Social";
                grid.Columns[3].HeaderText = "IVA";
                grid.Columns[4].HeaderText = "Renta Reten.";
                grid.Columns[5].HeaderText = "IVA Reten.";
                grid.Columns[6].HeaderText = "Fecha_Factura";
                grid.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                conexion.CerrarConexion();
                MessageBox.Show(ex.Message);
            }
        }
        public void CargaInicialGrid()
        {
            ConsultaFactura(dgfactura);
            
        }
        private void ConsultarFactura_Load(object sender, EventArgs e)
        {
            dtpdesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtphasta.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            CargaInicialGrid();
        }

        private void Btncrear_Click(object sender, EventArgs e)
        {
            formularios.factura.AdministrarFactura administrar = new AdministrarFactura();
            administrar.ShowDialog();
            CargaInicialGrid();
        }
        public static void FiltroConsultaFactura(DataGridView grid, string nombre)
        {
            clases.Conexion conexion = new clases.Conexion();
            try
            {

                conexion.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand("PROC_CONSULTAR_FACTURA_FILTRADA(@razon)", conexion.conexion);
                cmd.Parameters.AddWithValue("@razon", "%" + nombre + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid.DataSource = dt;
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                conexion.CerrarConexion();
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void Txtfiltro_TextChanged(object sender, EventArgs e)
        {
            FiltroConsultaFactura(dgfactura,txtfiltro.Text);
            dgfactura.Columns[0].HeaderText = "N. Factura";
            dgfactura.Columns[1].HeaderText = "RUC";
            dgfactura.Columns[2].HeaderText = "Razón Social";
            dgfactura.Columns[3].HeaderText = "IVA";
            dgfactura.Columns[4].HeaderText = "Renta Reten.";
            dgfactura.Columns[5].HeaderText = "IVA Reten.";
            dgfactura.Columns[6].HeaderText = "Fecha_Factura";
            dgfactura.AutoResizeColumns();
        }

        private void Btnrefrescar_Click(object sender, EventArgs e)
        {
            CargaInicialGrid();
            txtfiltro.Clear();
        }
        public static void ConsultaFechasNoCliente(DataGridView grid, DateTime desde, DateTime hasta)
        {
            clases.Conexion conexion = new clases.Conexion();
            try
            {

                conexion.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand("PROC_CONSULTA_FECHA_NO_CLIENTE(@desde,@hasta)", conexion.conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@desde", Convert.ToDateTime(desde).ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@hasta", Convert.ToDateTime(hasta).ToString("yyyy-MM-dd"));
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid.DataSource = dt;
                conexion.CerrarConexion();
                grid.Columns[0].HeaderText = "N. Factura";
                grid.Columns[1].HeaderText = "RUC";
                grid.Columns[2].HeaderText = "Razón Social";
                grid.Columns[3].HeaderText = "IVA";
                grid.Columns[4].HeaderText = "Renta Reten.";
                grid.Columns[5].HeaderText = "IVA Reten.";
                grid.Columns[6].HeaderText = "Fecha_Factura";
                grid.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                conexion.CerrarConexion();
                MessageBox.Show(ex.Message);
                return;
            }
        }
        public static void ConsultaFechasCliente(DataGridView grid, DateTime desde, DateTime hasta, string temp)
        {
            clases.Conexion conexion = new clases.Conexion();
            try
            {

                conexion.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand("PROC_CONSULTAR_FACTURA_FILTRADA_CLIENTE(@desde,@hasta,@temp)", conexion.conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@temp","%"+temp+"%");
                cmd.Parameters.AddWithValue("@desde", Convert.ToDateTime(desde).ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@hasta", Convert.ToDateTime(hasta).ToString("yyyy-MM-dd"));                
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid.DataSource = dt;
                conexion.CerrarConexion();
                grid.Columns[0].HeaderText = "N. Factura";
                grid.Columns[1].HeaderText = "RUC";
                grid.Columns[2].HeaderText = "Razón Social";
                grid.Columns[3].HeaderText = "IVA";
                grid.Columns[4].HeaderText = "Renta Reten.";
                grid.Columns[5].HeaderText = "IVA Reten.";
                grid.Columns[6].HeaderText = "Fecha_Factura";
                grid.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                conexion.CerrarConexion();
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpdesde.Value;
            DateTime hasta = dtphasta.Value;
            if (txtfiltro.Text == "")
            {
                ConsultaFechasNoCliente(dgfactura, desde, hasta);                
            }
            else
            {
                string temp = txtfiltro.Text;
                ConsultaFechasCliente(dgfactura, desde, hasta, temp);                
            }
            
        }
        public int EliminarFactura(int numfact)
        {
            int retorno = 0;
            clases.Conexion conexion = new clases.Conexion();
            try
            {
                conexion.AbrirConexion();                
                MySqlCommand cmd = new MySqlCommand("PROC_ELIMINAR_FACTURA(@pnum)", conexion.conexion);
                cmd.Parameters.AddWithValue("@pnum", numfact);
                retorno = cmd.ExecuteNonQuery();
                conexion.CerrarConexion();
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.CerrarConexion();
                return retorno;
            }
        }
        private void Btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult op = MessageBox.Show("¿Confirma que desea eliminar a: " + dgfactura.Rows[dgfactura.CurrentRow.Index].Cells[2].Value.ToString() + ".", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (op == DialogResult.Yes)
            {
                int retorno = EliminarFactura(Convert.ToInt32(dgfactura.Rows[dgfactura.CurrentRow.Index].Cells[0].Value.ToString()));
                if (retorno > 0)
                {
                    MessageBox.Show("Se ha realizado con exito la operación.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargaInicialGrid();
                }
                else
                    MessageBox.Show("Ocurrio un error durante la operación", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Operacion Cancelada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtfiltro.Clear();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            formularios.reporte.VentanaReporte rep = new formularios.reporte.VentanaReporte();
            rep.id_reporte = 0;
            rep.fdesde= dtpdesde.Value.Date;
            rep.fhasta = dtphasta.Value.Date;            
            rep.ShowDialog();
        }

        private void btnimprimirdet_Click(object sender, EventArgs e)
        {
            formularios.reporte.VentanaReporte rep = new formularios.reporte.VentanaReporte();
            rep.id_reporte = 1;
            rep.fdesde = dtpdesde.Value.Date;
            rep.fhasta = dtphasta.Value.Date;
            rep.ShowDialog();
        }
    }
}

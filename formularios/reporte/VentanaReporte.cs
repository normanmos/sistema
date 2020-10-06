using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace LatamDS.formularios.reporte
{
    public partial class VentanaReporte : Form
    {
        public DateTime fdesde { get; set; }
        public DateTime fhasta { get; set; }
        public int id_reporte { get; set; }
        public VentanaReporte()
        {
            InitializeComponent();
        }


        public void total(DateTime desde, DateTime hasta)
        {
            try
            {
                // metodo con clases
                DataTable Retornar = new DataTable();
                clases.Conexion conex = new clases.Conexion();             
                MySqlCommand cmd = new MySqlCommand("PROC_REPORTE_FACTURA_TOTALES(@desde,@hasta)", conex.conexion);
                cmd.Parameters.AddWithValue("@desde", desde);
                cmd.Parameters.AddWithValue("@hasta", hasta);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.SelectCommand = cmd;
                da.Fill(Retornar);

                List<clases.Factura> Agregar = new List<clases.Factura>();

                foreach (DataRow Lista in Retornar.Rows)
                {
                    Agregar.Add(new clases.Factura
                    {
                        Idfactura = Convert.ToInt32(Lista[0]),
                        Subtotal = Convert.ToInt32(Lista[1]),
                        Iva = Convert.ToInt32(Lista[2]),
                        Viva = Convert.ToInt32(Lista[3]),
                        Vrenta = Convert.ToInt32(Lista[4]),
                    }
                    );
                }
                ReportDataSource rds1 = new ReportDataSource("Factura", Agregar);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds1);
                this.reportViewer1.RefreshReport();
                // fin metodo con clases
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void detalle(DateTime desde, DateTime hasta)
        {
            try
            {
                clases.Conexion conex = new clases.Conexion();
                MySqlCommand cmd = new MySqlCommand("PROC_REPORTE_FACT_DET(@desde,@hasta)", conex.conexion);
                cmd.Parameters.AddWithValue("@desde", desde);
                cmd.Parameters.AddWithValue("@hasta", hasta);
                //DataSetReporte reporte = new DataSetReporte();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                //reporte.Clear();
                da.SelectCommand = cmd;
                //da.Fill(reporte.Tables["detalle"]);
                //totales
                MySqlCommand cmd2 = new MySqlCommand("PROC_REPORT_FACT_TOTALES(@desde,@hasta)", conex.conexion);
                cmd2.Parameters.AddWithValue("@desde", desde);
                cmd2.Parameters.AddWithValue("@hasta", hasta);
                da = new MySqlDataAdapter(cmd2);
                //this.DataSetReporte.Clear();
                da.SelectCommand = cmd2;
                //da.Fill(reporte.Tables["totales"]);
                this.reportViewer2.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void VentanaReporte_Load(object sender, EventArgs e)
        {
           
            reporte.DatosFactura fecha = new reporte.DatosFactura();
            fecha.inicio = fdesde.Date;
            fecha.fin = fhasta.Date;
            switch (id_reporte)
            {
                case 0:
                    reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                    reportViewer1.Visible = true;
                    reportViewer1.Dock = DockStyle.Fill;
                    total(fdesde, fhasta);
                    break;
                case 1:
                    reportViewer2.Visible = true;
                    //reportViewer2.Dock = DockStyle.Fill;
                    detalle(fdesde, fhasta);
                    this.reportViewer2.RefreshReport();
                    break;
            }
        }
   
    }
}

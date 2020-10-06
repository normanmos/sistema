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
    public partial class AdministrarFactura : Form
    {
        public AdministrarFactura()
        {
            InitializeComponent();
        }
        int ConsultarNum()
        {
            clases.Conexion conexion = new clases.Conexion();
            try
            {
                int id = 0;
                conexion.AbrirConexion();
                //MySqlCommand cmd = new MySqlCommand("select max(idfactura) from test_app2.factura;", conexion.conexion);
                MySqlCommand cmd = new MySqlCommand("PROC_CONSULTAR_NFACTURA", conexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                conexion.CerrarConexion();
                return id + 1;
            }
            catch (Exception ex)
            {
                conexion.CerrarConexion();
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        int Incrementar(int valor)
        {
            return ++valor;
        }
        int Decrementar(int valor)
        {
            return --valor;
        }
        private void AdministrarFactura_Load(object sender, EventArgs e)
        {
            dtpicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, 1);
            txtfnumfact.Text = Convert.ToString(ConsultarNum());            
        }
        private void Btnincrementar_Click(object sender, EventArgs e)
        {
            txtfnumfact.Text = Convert.ToString(Incrementar(Convert.ToInt32(txtfnumfact.Text)));
        }
        private void Btndisminuir_Click(object sender, EventArgs e)
        {
            txtfnumfact.Text = Convert.ToString(Decrementar(Convert.ToInt32(txtfnumfact.Text)));
        }

        private void Txtfsubt_TextChanged(object sender, EventArgs e)
        {
            if (txtfsubt.Text != "" && txtfnombre.Text != "" && txtpiva.Text != "" && txtprenta.Text != "")
            {

                txtfiva.Text = Convert.ToString(Convert.ToDecimal(txtfsubt.Text) * Convert.ToDecimal(0.12));
                decimal iva = Convert.ToDecimal(txtfiva.Text);
                decimal v_renta =0;
                //% de retencion iva
                switch (txtpiva.Text)
                {
                    case "100":
                        txtfviva.Text = Convert.ToString(iva);
                        break;
                    case "70":
                        txtfviva.Text = Convert.ToString(iva * Convert.ToDecimal(0.7));
                        break;
                    case "30":
                        txtfviva.Text = Convert.ToString(iva * Convert.ToDecimal(0.3));
                        break;
                    case "0":
                        txtfviva.Text = "0";
                        break;
                }
                //porcentaje retencion renta
                switch (txtprenta.Text)
                {
                    case "0":
                        txtfvrenta.Text = "0";
                        break;
                    case "1":
                        v_renta = (Convert.ToDecimal(txtfsubt.Text) * Convert.ToDecimal(0.01));
                        txtfvrenta.Text = Convert.ToString(v_renta);
                        break;
                    case "1.75":
                        v_renta = (Convert.ToDecimal(txtfsubt.Text) * Convert.ToDecimal(0.0175));
                        txtfvrenta.Text = Convert.ToString(v_renta);
                        break;
                }
            }            
            else if(txtfruc.Text==""&&txtfsubt.Enabled==false)
            {
                MessageBox.Show("Ingresa datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            formularios.cliente.ConsultarCliente tomar = new cliente.ConsultarCliente();
            tomar.ShowDialog();
            if(tomar.ClienteSelecionado!=null)
            {
                txtfnombre.Text = tomar.ClienteSelecionado.RazonSocial.Trim();
                txtfruc.Text = tomar.ClienteSelecionado.Ruc.Trim();
                txtprenta.Text = Convert.ToString(tomar.ClienteSelecionado.Renta);
                txtpiva.Text = Convert.ToString(tomar.ClienteSelecionado.Iva);
                txtfsubt.Enabled = true;
            }
            else
            {
                MessageBox.Show("Seleccione al menos un cliente");
            }
        }
        public  int InsercionFactura(clases.Factura objeto)
        {
            clases.Conexion conexion = new clases.Conexion();
            try
            {
                conexion.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand("PROC_INGRESAR_FACTURA(@pnum,@pruc,@psubtotal,@piva,@pv_renta,@pv_iva,@pfecha)", conexion.conexion);
                cmd.Parameters.AddWithValue("@pnum", objeto.Idfactura);
                cmd.Parameters.AddWithValue("@pruc", objeto.Ruc);
                cmd.Parameters.AddWithValue("@psubtotal", objeto.Subtotal);
                cmd.Parameters.AddWithValue("@piva", objeto.Iva);
                cmd.Parameters.AddWithValue("@pv_renta", objeto.Vrenta);
                cmd.Parameters.AddWithValue("@pv_iva", objeto.Viva);
                cmd.Parameters.AddWithValue("@pfecha", objeto.Fecha.ToString("yyyy-MM-dd"));
                int retorno = cmd.ExecuteNonQuery();
                conexion.CerrarConexion();
                return retorno;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.CerrarConexion();
                return 0;
            }
        }
        void limpiar_datos()
        {
            txtfnombre.Clear();
            txtfnumfact.Text = (Convert.ToString(Incrementar(Convert.ToInt32(txtfnumfact.Text))));
            txtfruc.Clear();
            txtfsubt.Clear();
            txtfiva.Clear();
            txtpiva.Clear();
            txtprenta.Clear();
            txtfviva.Clear();
            txtfvrenta.Clear();
            //dtpicker.Text = "";
        }
        private void Btnguardar_Click(object sender, EventArgs e)
        {
            if (txtfruc.Text != "" && txtfsubt.Text != "" && txtfviva.Text != "" && txtfvrenta.Text != "" && txtfviva.Text != "")
            {
                clases.Factura objeto = new clases.Factura();
                objeto.Idfactura = Convert.ToInt32(txtfnumfact.Text);
                objeto.Ruc = txtfruc.Text;
                objeto.Subtotal = Convert.ToDecimal(txtfsubt.Text);
                objeto.Iva = Convert.ToDecimal(txtfiva.Text);
                objeto.Vrenta = Convert.ToDecimal(txtfvrenta.Text);
                objeto.Viva = Convert.ToDecimal(txtfviva.Text);
                objeto.Fecha = dtpicker.Value.Date;
                {
                    int retorno = InsercionFactura(objeto);
                    if (retorno > 0)
                    {
                        MessageBox.Show("Factura guardada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar_datos();
                        txtfsubt.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error, revisar datos ingresados.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (txtfruc.Text==""&&txtfsubt.Text==""&&txtfsubt.Enabled!=true)
            {
                MessageBox.Show("Por favor ingresa datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}

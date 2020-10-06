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

namespace LatamDS.formularios.cliente
{
    public partial class ConsultarCliente : Form
    {
        public clases.Cliente ClienteSelecionado { get; set; }
        public ConsultarCliente()
        {
            InitializeComponent();
        }
        public int EliminarCliente(string ruc)
        {
            int retorno = 0;
            clases.Conexion conexion = new clases.Conexion();
            try
            {
                conexion.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand("PROC_ELIMINAR_CLIENTE(@PRUC)", conexion.conexion);
                cmd.Parameters.AddWithValue("@PRUC",ruc);
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
        private void Btncrear_Click(object sender, EventArgs e)
        {
            formularios.cliente.AdministarCliente administrar = new AdministarCliente();
            administrar.ShowDialog();
            CargaInicialGrid();
        }
        void ConsultaCliente(DataGridView grid)
        {
            clases.Conexion conexion = new clases.Conexion();
            try
            {

                conexion.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand("PROC_CONSULTAR_CLIENTE", conexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
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
            }
        }
        public static void FiltroConsultaCliente(DataGridView grid, string nombre)
        {
            clases.Conexion conexion = new clases.Conexion();
            try
            {

                conexion.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand("PROC_CONSULTAR_CLIENTE_FILTRO(@razon)", conexion.conexion);
                cmd.Parameters.AddWithValue("@razon","%"+nombre+"%");
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
        public void CargaInicialGrid()
        {
            ConsultaCliente(dgcliente);
            dgcliente.Columns[0].HeaderText = "RUC";
            dgcliente.Columns[1].HeaderText = "Razón Social";
            dgcliente.Columns[2].HeaderText = "Ciudad";
            dgcliente.Columns[3].HeaderText = "Telefonos";
            dgcliente.Columns[4].HeaderText = "% IVA";
            dgcliente.Columns[5].HeaderText = "% RENTA";
            dgcliente.AutoResizeColumns();
        }        
        private void ConsultarCliente_Load(object sender, EventArgs e)
        {
            CargaInicialGrid();
        }
        private void Txtfiltro_TextChanged(object sender, EventArgs e)
        {
            FiltroConsultaCliente(dgcliente,txtfiltro.Text);
            dgcliente.Columns[0].HeaderText = "RUC";
            dgcliente.Columns[1].HeaderText = "Razón Social";
            dgcliente.Columns[2].HeaderText = "Ciudad";
            dgcliente.Columns[3].HeaderText = "Telefonos";
            dgcliente.Columns[4].HeaderText = "% IVA";
            dgcliente.Columns[5].HeaderText = "% RENTA";
            dgcliente.AutoResizeColumns();
        }
        private void Btnrefrescar_Click(object sender, EventArgs e)
        {
            CargaInicialGrid();
            txtfiltro.Clear();
        }
        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            string ruc = dgcliente.Rows[dgcliente.CurrentRow.Index].Cells[0].Value.ToString();
            formularios.cliente.AdministarCliente administar = new AdministarCliente();
            clases.Conexion conexion = new clases.Conexion();
            try
            {

                conexion.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand("PROC_CONSULTAR_CLIENTE_SET(@razon)", conexion.conexion);
                cmd.Parameters.AddWithValue("@razon",dgcliente.Rows[dgcliente.CurrentRow.Index].Cells[1].Value.ToString());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow valor = dt.Rows[0];
                administar.ruc = valor[1].ToString();
                administar.razon_social = valor[0].ToString();
                administar.direccion = valor[2].ToString();
                administar.ciudad = valor[3].ToString();
                administar.telefonos = valor[4].ToString();
                administar.correo = valor[5].ToString();
                administar.iva = valor[6].ToString();
                administar.renta = valor[7].ToString();
                administar.op_guardar = 1;
                conexion.CerrarConexion();                
            }
            catch (Exception ex)
            {
                conexion.CerrarConexion();
                MessageBox.Show(ex.Message);
                return;
            }
            txtfiltro.Clear();
            administar.ShowDialog();
            CargaInicialGrid();
        }
        private void Btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult op = MessageBox.Show("¿Confirma que desea eliminar a: " + dgcliente.Rows[dgcliente.CurrentRow.Index].Cells[1].Value.ToString()+".","ATENCION",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(op==DialogResult.Yes)
            {
                int retorno=EliminarCliente(dgcliente.Rows[dgcliente.CurrentRow.Index].Cells[0].Value.ToString());
                if (retorno > 0)
                {
                    MessageBox.Show("Se ha realizado con exito la operación.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargaInicialGrid();
                }
                else
                    MessageBox.Show("Ocurrio un error durante la operación", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else{
                MessageBox.Show("Operacion Cancelada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtfiltro.Clear();
        }

        private void Dgcliente_DoubleClick(object sender, EventArgs e)
        {
            if (dgcliente.SelectedRows.Count == 1)
            {                                
                clases.Cliente objeto = new clases.Cliente();
                objeto.Ruc = dgcliente.Rows[dgcliente.CurrentRow.Index].Cells[0].Value.ToString();
                objeto.RazonSocial= dgcliente.Rows[dgcliente.CurrentRow.Index].Cells[1].Value.ToString();
                objeto.Iva= Int32.Parse(dgcliente.Rows[dgcliente.CurrentRow.Index].Cells[4].Value.ToString());
                objeto.Renta= decimal.Parse(dgcliente.Rows[dgcliente.CurrentRow.Index].Cells[5].Value.ToString());
                ClienteSelecionado = objeto;
                this.Close();
            }
            else
                MessageBox.Show("Seleccione al menos un cliente");
        }
    }
}

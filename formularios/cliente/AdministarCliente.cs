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
    public partial class AdministarCliente : Form
    {
        public AdministarCliente()
        {
            InitializeComponent();
        }
        int op = 0;
        public string razon_social { set { txtclinom.Text = value; } }
        public string ruc { set{txtcliruc.Text = value; } }
        public string direccion { set{txtclidir.Text = value; } }
        public string ciudad { set { txtcliciu.Text = value; } }
        public string telefonos {set { txtclitel.Text = value; }}
        public string correo { set { txtclicorreo.Text = value; } }
        public string iva { set { cmbiva.Text = value; } }
        public string renta { set { cmbrenta.Text = value; } }
        public int op_guardar { set { op = 1; } }
        public int InsercionCliente(clases.Cliente objeto,int op)
        {
            if (op == 0)
            {
                clases.Conexion conexion = new clases.Conexion();
                try
                {
                    conexion.AbrirConexion();
                    MySqlCommand cmd = new MySqlCommand("PROC_INGRESAR_CLIENTE(@PRAZON,@PRUC,@PDIRECCION,@PCIUDAD,@PTELEFONOS,@PCORREO,@PIVA,@PRENTA)", conexion.conexion);
                    cmd.Parameters.AddWithValue("@PRAZON", objeto.RazonSocial);
                    cmd.Parameters.AddWithValue("@PRUC", objeto.Ruc);
                    cmd.Parameters.AddWithValue("@PDIRECCION", objeto.Direccion);
                    cmd.Parameters.AddWithValue("@PCIUDAD", objeto.Ciudad);
                    cmd.Parameters.AddWithValue("@PTELEFONOS", objeto.Telefonos);
                    cmd.Parameters.AddWithValue("@PCORREO", objeto.Correo);
                    cmd.Parameters.AddWithValue("@PIVA", objeto.Iva);
                    cmd.Parameters.AddWithValue("@PRENTA", objeto.Renta);
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
            else
            {
                clases.Conexion conexion = new clases.Conexion();
                try
                {
                    conexion.AbrirConexion();
                    MySqlCommand cmd = new MySqlCommand("PROC_ACTUALIZAR_CLIENTE(@PRAZON,@PRUC,@PDIRECCION,@PCIUDAD,@PTELEFONOS,@PCORREO,@PIVA,@PRENTA)", conexion.conexion);
                    cmd.Parameters.AddWithValue("@PRAZON", objeto.RazonSocial);
                    cmd.Parameters.AddWithValue("@PRUC", objeto.Ruc);
                    cmd.Parameters.AddWithValue("@PDIRECCION", objeto.Direccion);
                    cmd.Parameters.AddWithValue("@PCIUDAD", objeto.Ciudad);
                    cmd.Parameters.AddWithValue("@PTELEFONOS", objeto.Telefonos);
                    cmd.Parameters.AddWithValue("@PCORREO", objeto.Correo);
                    cmd.Parameters.AddWithValue("@PIVA", objeto.Iva);
                    cmd.Parameters.AddWithValue("@PRENTA", objeto.Renta);
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
        }
        void LimpiarDatos()
        {
            txtclinom.Clear();
            txtcliruc.Clear();
            txtclidir.Clear();
            txtcliciu.Clear();
            txtclitel.Clear();
            txtclicorreo.Clear();
            cmbiva.Text = "";
            cmbrenta.Text = "";
        }
        private void Btnguardar_Click(object sender, EventArgs e)
        {
            if(op==0)
            {
                clases.Cliente objeto = new clases.Cliente();
                objeto.RazonSocial = txtclinom.Text.ToUpper().Trim();
                objeto.Ruc = txtcliruc.Text.ToUpper().Trim();
                objeto.Direccion = txtclidir.Text.ToUpper().Trim();
                objeto.Ciudad = txtcliciu.Text.ToUpper().Trim();
                objeto.Telefonos = txtclitel.Text.ToUpper().Trim();
                objeto.Correo = txtclicorreo.Text.ToUpper().Trim();
                if (cmbiva.Text == "" || cmbiva.Text == " ")
                    objeto.Iva = 0;
                else
                    objeto.Iva = Int32.Parse(cmbiva.Text);
                if (cmbrenta.Text == "" || cmbrenta.Text == " ")
                    objeto.Renta = 0;
                else
                    objeto.Renta = Int32.Parse(cmbrenta.Text);

                if (txtcliruc.Text != "" && txtclinom.Text != "" && txtclidir.Text != "" && InsercionCliente(objeto,0) > 0)
                {
                    MessageBox.Show("Cliente guardado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarDatos();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error, revisar datos ingresados.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //modificar detona con op mayor a 0
            else
            {
                
                clases.Cliente objeto = new clases.Cliente();
                objeto.RazonSocial = txtclinom.Text.ToUpper().Trim();
                objeto.Ruc = txtcliruc.Text.ToUpper().Trim();
                objeto.Direccion = txtclidir.Text.ToUpper().Trim();
                objeto.Ciudad = txtcliciu.Text.ToUpper().Trim();
                objeto.Telefonos = txtclitel.Text.ToUpper().Trim();
                objeto.Correo = txtclicorreo.Text.ToUpper().Trim();
                if (cmbiva.Text == "" || cmbiva.Text == " ")
                    objeto.Iva = 0;
                else
                    objeto.Iva = Int32.Parse(cmbiva.Text);
                if (cmbrenta.Text == "" || cmbrenta.Text == " ")
                    objeto.Renta = 0;
                else
                    objeto.Renta = Int32.Parse(cmbrenta.Text);

                if (txtcliruc.Text != "" && txtclinom.Text != "" && txtclidir.Text != "" && InsercionCliente(objeto,1) > 0)
                {
                    MessageBox.Show("Cliente actualizado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarDatos();
                    txtcliruc.ReadOnly = false;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error, revisar datos ingresados.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
        }

        private void AdministarCliente_Load(object sender, EventArgs e)
        {
            if(op==1)
                txtcliruc.ReadOnly = true;
        }
    }
}

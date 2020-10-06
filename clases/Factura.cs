using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatamDS.clases
{
    public class Factura
    {
        public int Idfactura { get; set; }
        public string Ruc { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Vrenta { get; set; }
        public decimal Viva { get; set; }
        public DateTime Fecha { get; set; }

        public Factura() { }

        public Factura(int pidfactura, string pruc, decimal psubtotal, decimal piva, decimal pv_renta, decimal pv_iva, DateTime pfecha)
        {
            this.Idfactura = pidfactura;
            this.Ruc = pruc;
            this.Subtotal = psubtotal;
            this.Iva = piva;
            this.Vrenta = pv_renta;
            this.Viva = pv_iva;
            this.Fecha = pfecha;
        }
    }
}

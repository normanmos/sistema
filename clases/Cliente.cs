using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatamDS.clases
{
    public class Cliente
    {
        public string RazonSocial { get; set; }
        public string Ruc { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Telefonos { get; set; }
        public string Correo { get; set; }
        public int Iva { get; set; }
        public decimal Renta { get; set; }

        public Cliente() { }

        public Cliente(string prazon_social, string pruc, string pdireccion, string pciudad, string ptelefonos, string pcorreo, int piva, decimal prenta)
        {
            this.RazonSocial = prazon_social;
            this.Ruc = pruc;
            this.Direccion = pdireccion;
            this.Ciudad = pciudad;
            this.Telefonos = ptelefonos;
            this.Correo = pcorreo;
            this.Iva = piva;
            this.Renta = prenta;
        }
    }
}

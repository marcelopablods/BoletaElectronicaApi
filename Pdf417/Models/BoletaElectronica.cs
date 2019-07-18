using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pdf417.Models
{
    public class BoletaElectronica
    {
        public int numDoc { get; set; }
        public int estado { get; set; }
        public string rutEmisor { get; set; }
        public string tipoDocu { get; set; }
        public int folioDte { get; set; }
        public string fechaFact { get; set; }
        public string nombreCliente { get; set; }
        public int montoNeto { get; set; }
        public int montoexento { get; set; }
        public int montoIva { get; set; }
        public int montoTotal { get; set; }
        public string montoTxt { get; set; }
        public string timbreDte { get; set; }
        public string dteCompleto { get; set; }
        public string archivoPdf { get; set; }
        public int linea { get; set; }
        public string glosa { get; set; }
        public int cantidad { get; set; }
        public string unidad { get; set; }
        public int precioUnitario { get; set; }
        public int monto { get; set; }
        public int exento { get; set; }

        
         public string logoEmpresa { get; set; }
         public string fechaVenc { get; set; }
         public string rutCliente { get; set; }
         public string direccion { get; set; }
         public string comuna { get; set; }
         public string ciudad { get; set; }
         public string giro { get; set; }
         public string observacion { get; set; }
         public string formaPago { get; set; }
         public string vendedor { get; set; }
         public string noOperacion { get; set; }
         
         


    }
}
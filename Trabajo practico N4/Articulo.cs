using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trabajo_practico_N4
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int? IdMarca { get; set; }
        public int? IdCategoria { get; set; }
        public decimal Precio { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trabajo_practico_N4
{
    public class voucher
    {
        public string CodigoVoucher { get; set; }
        public int? IdCliente { get; set; } // Puede ser null
        public DateTime? FechaCanje { get; set; } // Puede ser null
        public int? IdArticulo { get; set; }
    }
}
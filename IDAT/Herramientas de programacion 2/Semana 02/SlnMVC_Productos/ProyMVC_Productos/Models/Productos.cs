using System;

namespace ProyMVC_Productos.Models
{
    public class Productos
    {
        public int cod_prod { get; set; }
        public string nom_prod { get; set; }
        public decimal pre_prod { get; set; }
        public int stk_prod { get; set; }
        public DateTime fecha_cad { get; set; }
    }
}

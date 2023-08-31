using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_2nd.Modelos
{
    public class Det_factura
    {
        private string num_factura;
        private string cod_producto;

        public Det_factura()
        {

        }

        public string Num_factura { get => num_factura; set => num_factura = value; }
        public string Cod_producto { get => cod_producto; set => cod_producto = value; }
    }
}

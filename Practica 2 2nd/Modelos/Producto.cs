using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_2nd.Modelos
{
    public class Producto
    {
        private string cod;
        private string nombre;
        private string precio;
        private string stock;
        public Producto() { }

        public string Cod { get => cod; set => cod = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Precio { get => precio; set => precio = value; }
        public string Stock { get => stock; set => stock = value; }

        public override string ToString()
        {
            return Cod + " " + Nombre + " " + Precio + " " + Stock;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_2nd.Modelos
{
    public class Cliente
    {
        private string cedula;
        private string nombre;
        private string apellido;
       

        public Cliente()
        {
          
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public override string ToString()
        {
            return  Cedula + " " + Nombre + " " + Apellido;
        }
    }
}

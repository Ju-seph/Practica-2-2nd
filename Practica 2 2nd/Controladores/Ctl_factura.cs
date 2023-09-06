using Practica_2_2nd.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2_2nd.Controladores
{
    public class Ctl_factura
    {
        List<Factura> lista;

        public Ctl_factura()
        {
            lista = new List<Factura>();
        }

        public void Add_lista(Factura user)
        {
            lista.Add(user);
        }

        public string Imp()
        {
            string datos = "";

            foreach (Factura user in lista)
            {
                datos += user.ToString() + "\n";
            }
            return datos;
        }

        public void Mostrar_Tabla(DataGridView tabla)
        {
            tabla.Rows.Clear();
            foreach (Factura user in lista)
            {
                tabla.Rows.Add(user.Num_factura, user.Ced_cliente, user.Fecha, user.Total);
            }
        }

    }
}

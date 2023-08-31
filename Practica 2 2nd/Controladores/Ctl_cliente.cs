using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_2_2nd.Modelos;
using System.Windows.Forms;

namespace Practica_2_2nd.Controladores
{
    public class Ctl_cliente
    {
        List<Cliente> lista;

        public Ctl_cliente()
        {
            lista = new List<Cliente>();
        }

        public void Add_lista(Cliente user)
        {
            lista.Add(user);
        }

        public string Imp()
        {
            string datos = "";

            foreach (Cliente user in lista)
            {
                datos += user.ToString() + "\n";
            }
            return datos;
        }
         public void Mostrar_Tabla(DataGridView tabla)
        {
            tabla.Rows.Clear();
            foreach(Cliente user in lista) 
            {
               tabla.Rows.Add(user.Cedula,user.Nombre,user.Apellido);
            }
        }

        public Cliente Buscar_x_Cedula(string cedula)
        {
            return lista.Find(us=> us.Cedula.Equals(cedula));
        }

        public void Remover_Tabla(DataGridView tabla)
        {
            tabla.Rows.Clear();
        }

        public int pos_x_cedula(string cedula)
        {
            return lista.FindIndex(us => us.Cedula.Equals(cedula));
        }

        public void Editar_Usuario(int pos, Cliente cliente)
        {
            lista[pos] = cliente;
        }

        public void Eliminar_usuario(int pos)
        {
            lista.RemoveAt(pos);
        }
    }
}

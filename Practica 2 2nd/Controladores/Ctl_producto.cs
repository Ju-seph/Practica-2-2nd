using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica_2_2nd.Modelos;

namespace Practica_2_2nd.Controladores
{
    public class Ctl_producto
    {
        List<Producto> lista;

        public Ctl_producto()
        {
            lista = new List<Producto>();
        }

        public void Add_Lista(Producto user)
        {
            lista.Add(user);
        }

        public string Imp()
        {
            string datos = "";

            foreach (Producto user in lista)
            {
                datos += user.ToString() + "\n";
            }
            return datos;
        }

        public void Mostrar_Tabla(DataGridView tabla)
        {
            tabla.Rows.Clear();
            foreach (Producto user in lista)
            {
                tabla.Rows.Add(user.Cod,user.Nombre,user.Precio,user.Stock);
            }
        }

        public Producto Buscar_x_Codigo(string cod)
        {
            return lista.Find(us=> us.Cod.Equals(cod));
        }

        public void Remover_Tabla(DataGridView tabla)
        {
            tabla.Rows.Clear();
        }

        public int pos_x_codigo(string cod)
        {
            return lista.FindIndex(us=> us.Cod.Equals(cod));
        }

        public void Editar_Usuario(int pos, Producto producto)
        {
            lista[pos] = producto;
        }

        public void Eliminar_usuario(int pos)
        {
            lista.RemoveAt(pos);
        }

        public int Obtener_cod()
        {
            int id = 0;
           
            if (lista.Count>0)
            {
                    id = Convert.ToInt32(lista.Last().Cod);
               
            }  
            
            return id + 1;
        }
    }
}

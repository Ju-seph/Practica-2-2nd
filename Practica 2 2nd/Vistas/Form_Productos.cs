using Practica_2_2nd.Controladores;
using Practica_2_2nd.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2_2nd.Vistas
{
    public partial class Form_Productos : Form
    {
        Ctl_producto ctl_producto= new Ctl_producto();
        public Form_Productos()
        {
            InitializeComponent();
            beditar.Enabled = false;
            beliminar.Enabled = false;
            update_codigo();
           
        }

        public void update_codigo()
        {
            txtcodigo.Text = ctl_producto.Obtener_cod().ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bagregar_Click(object sender, EventArgs e)
        {
            Producto user = new Producto
            {
                Cod = txtcodigo.Text,
                Nombre = txtnombre.Text,
                Precio = txtprecio.Text,
                Stock = txtstock.Text,
            };

            ctl_producto.Add_Lista(user);

            MessageBox.Show("USUARIO GUARDADO CORRECTAMENTE", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ctl_producto.Imp();

            update_codigo();
            
            ctl_producto.Mostrar_Tabla(tabla);
            Limpiar();
        }

        private void Limpiar()
        {
            update_codigo();
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";
            
        }

        private void tabla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string cedula = tabla.Rows[e.RowIndex].Cells[0].Value.ToString();

                Producto user = ctl_producto.Buscar_x_Codigo(cedula);

               txtcodigo.Text = user.Cod;
                txtnombre.Text = user.Nombre;
                txtprecio.Text = user.Precio;
                txtstock.Text = user.Stock;


                beditar.Enabled = true;
                bagregar.Enabled = false;
                beliminar.Enabled = true;
            }
 
            ctl_producto.Mostrar_Tabla(tabla);
        }

        private void beditar_Click(object sender, EventArgs e)
        {
            int pos = ctl_producto.pos_x_codigo(txtcodigo.Text);

            Producto user = new Producto
            {
                Cod = txtcodigo.Text,
                Nombre = txtnombre.Text,
                Precio = txtprecio.Text,
                Stock=txtstock.Text,
            };

            ctl_producto.Editar_Usuario(pos, user);
            bagregar.Enabled = true;
            beditar.Enabled = false;
            beliminar.Enabled = false;
            Limpiar();

            ctl_producto.Mostrar_Tabla(tabla);
        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            int pos = ctl_producto.pos_x_codigo(txtcodigo.Text);
            if (pos != -1)
            {
                ctl_producto.Eliminar_usuario(pos);
                Limpiar();

                ctl_producto.Mostrar_Tabla(tabla);

                beliminar.Enabled = false;
                bagregar.Enabled = true;
                beditar.Enabled=false;
            }
            else
            {
                MessageBox.Show("ERROR AL ELIMINAR", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ctl_producto.Mostrar_Tabla(tabla);
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

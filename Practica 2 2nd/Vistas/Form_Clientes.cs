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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practica_2_2nd.Vistas
{
    public partial class Form_Clientes : Form
    {

       
        public Form_Clientes()
        {
            InitializeComponent();
            Form_Principal.ctl_cliente.Mostrar_Tabla(tabla);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void bagregar_Click(object sender, EventArgs e)
        {
            int pos = Form_Principal.ctl_cliente.pos_x_cedula(txtcedula.Text.Trim());
            if (pos ==-1)
            {
                Cliente user = new Cliente
                {
                    Cedula = txtcedula.Text.Trim(),
                    Nombre = txtnombre.Text.ToUpper(),
                    Apellido = txtapellido.Text.ToUpper()

                };

                Form_Principal.ctl_cliente.Add_lista(user);

                MessageBox.Show("CLIENTE GUARDADO CORRECTAMENTE", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form_Principal.ctl_cliente.Imp();
            }
            else
            {
                MessageBox.Show("CLIENTE REPETIDO", "NOTIFICACION");
            }

            

            Form_Principal.ctl_cliente.Mostrar_Tabla(tabla);
            Limpiar();

        }

        private void Limpiar()
        {
            txtcedula.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
        }

        private void tabla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string cedula = tabla.Rows[e.RowIndex].Cells[0].Value.ToString();

                Cliente user = Form_Principal.ctl_cliente.Buscar_x_Cedula(cedula);

                txtcedula.Text = user.Cedula;
                txtnombre.Text = user.Nombre;
                txtapellido.Text = user.Apellido;

                
                beditar.Enabled = true;
                bagregar.Enabled = false;
                beliminar.Enabled = true;
            }

            Form_Principal.ctl_cliente.Mostrar_Tabla(tabla);
        }

        private void beditar_Click(object sender, EventArgs e)
        {
            int pos = Form_Principal.ctl_cliente.pos_x_cedula(txtcedula.Text);
            if (pos !=-1)
            {
                Cliente user = new Cliente
                {
                    Cedula = txtcedula.Text,
                    Nombre = txtnombre.Text,
                    Apellido = txtapellido.Text

                };

                Form_Principal.ctl_cliente.Editar_Usuario(pos, user);
                MessageBox.Show("CLIENTE ACTUALIZADO CORRECTAMENTE", "NOTIFICACION");
            }
            else
            {
                MessageBox.Show(" ERROR AL ACTUALIZAR AL CLIENTE ", "NOTIFICACION");
            }

           Limpiar();
            Form_Principal.ctl_cliente.Mostrar_Tabla(tabla);

            bagregar.Enabled=true;
        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            int pos = Form_Principal.ctl_cliente.pos_x_cedula(txtcedula.Text);
            if (pos != -1)
            {
                Form_Principal.ctl_cliente.Eliminar_usuario(pos);
                Limpiar();

                Form_Principal.ctl_cliente.Mostrar_Tabla(tabla);

                beliminar.Enabled = false;
                bagregar.Enabled = true;
                bagregar.Enabled = true;
            }
            else
            {
                MessageBox.Show("NO EXISTE EL CLIENTE A ELIMINAR", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Form_Principal.ctl_cliente.Mostrar_Tabla(tabla);
           
        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
           
        }
    }
}

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
    public partial class Form_Factura : Form
    {
        public Form_Factura()
        {
            InitializeComponent();

            lanumero.Text= "Fact N # " + Form_Principal.ctl_factura.num_factura();

            ladia.Text= DateTime.Now.ToString();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void texcedula_TextChanged(object sender, EventArgs e)
        {
            if (texcedula.Text.Length == 10)
            {
                Cliente cli= Form_Principal.ctl_cliente.Buscar_x_Cedula(texcedula.Text);

                if (cli!= null)
                {
                    labelname.Text = cli.Nombre + " " + cli.Apellido;
                }
                else
                {
                    labelname.Text = "---";
                }
            }
        }
    }
}

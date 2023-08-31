using Practica_2_2nd.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2_2nd
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void bcliente_Click(object sender, EventArgs e)
        {
            Form_Clientes form_cli = new Form_Clientes();
            form_cli.Show();
        }

        private void bproducto_Click(object sender, EventArgs e)
        {
            Form_Productos form_pro=new Form_Productos();
            form_pro.Show();
        }

        private void bfactura_Click(object sender, EventArgs e)
        {
           
        }
    }
}

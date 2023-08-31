namespace Practica_2_2nd
{
    partial class Form_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bfactura = new System.Windows.Forms.Button();
            this.bproducto = new System.Windows.Forms.Button();
            this.bcliente = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bfactura, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bproducto, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bcliente, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 386);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bfactura
            // 
            this.bfactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bfactura.Location = new System.Drawing.Point(3, 196);
            this.bfactura.Name = "bfactura";
            this.bfactura.Size = new System.Drawing.Size(394, 187);
            this.bfactura.TabIndex = 2;
            this.bfactura.Text = "Facturas";
            this.bfactura.UseVisualStyleBackColor = true;
            this.bfactura.Click += new System.EventHandler(this.bfactura_Click);
            // 
            // bproducto
            // 
            this.bproducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bproducto.Location = new System.Drawing.Point(403, 3);
            this.bproducto.Name = "bproducto";
            this.bproducto.Size = new System.Drawing.Size(394, 187);
            this.bproducto.TabIndex = 1;
            this.bproducto.Text = "Productos";
            this.bproducto.UseVisualStyleBackColor = true;
            this.bproducto.Click += new System.EventHandler(this.bproducto_Click);
            // 
            // bcliente
            // 
            this.bcliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bcliente.Location = new System.Drawing.Point(3, 3);
            this.bcliente.Name = "bcliente";
            this.bcliente.Size = new System.Drawing.Size(394, 187);
            this.bcliente.TabIndex = 0;
            this.bcliente.Text = "Clientes";
            this.bcliente.UseVisualStyleBackColor = true;
            this.bcliente.Click += new System.EventHandler(this.bcliente_Click);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 386);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form_Principal";
            this.Text = "Form_Principal";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bfactura;
        private System.Windows.Forms.Button bproducto;
        private System.Windows.Forms.Button bcliente;
    }
}


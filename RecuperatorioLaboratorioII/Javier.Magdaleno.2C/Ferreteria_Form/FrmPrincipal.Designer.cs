namespace Ferreteria_Form
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxUsuario = new System.Windows.Forms.GroupBox();
            this.btnMostrarProductos = new System.Windows.Forms.Button();
            this.richTextBoxMostrarProductos = new System.Windows.Forms.RichTextBox();
            this.btnBuscarProductos = new System.Windows.Forms.Button();
            this.groupBoxCompras = new System.Windows.Forms.GroupBox();
            this.groupBoxInventario = new System.Windows.Forms.GroupBox();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnAltaProducto = new System.Windows.Forms.Button();
            this.btnCarrito = new System.Windows.Forms.Button();
            this.groupBoxUsuario.SuspendLayout();
            this.groupBoxCompras.SuspendLayout();
            this.groupBoxInventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUsuario
            // 
            this.groupBoxUsuario.Controls.Add(this.groupBoxInventario);
            this.groupBoxUsuario.Controls.Add(this.groupBoxCompras);
            this.groupBoxUsuario.Controls.Add(this.richTextBoxMostrarProductos);
            this.groupBoxUsuario.Location = new System.Drawing.Point(13, 14);
            this.groupBoxUsuario.Name = "groupBoxUsuario";
            this.groupBoxUsuario.Size = new System.Drawing.Size(678, 422);
            this.groupBoxUsuario.TabIndex = 0;
            this.groupBoxUsuario.TabStop = false;
            this.groupBoxUsuario.Text = "Usuario";
            // 
            // btnMostrarProductos
            // 
            this.btnMostrarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarProductos.Location = new System.Drawing.Point(6, 60);
            this.btnMostrarProductos.Name = "btnMostrarProductos";
            this.btnMostrarProductos.Size = new System.Drawing.Size(188, 31);
            this.btnMostrarProductos.TabIndex = 0;
            this.btnMostrarProductos.Text = "Mostrar Productos";
            this.btnMostrarProductos.UseVisualStyleBackColor = true;
            this.btnMostrarProductos.Click += new System.EventHandler(this.btnMostrarProductos_Click);
            // 
            // richTextBoxMostrarProductos
            // 
            this.richTextBoxMostrarProductos.Location = new System.Drawing.Point(211, 19);
            this.richTextBoxMostrarProductos.Name = "richTextBoxMostrarProductos";
            this.richTextBoxMostrarProductos.Size = new System.Drawing.Size(446, 382);
            this.richTextBoxMostrarProductos.TabIndex = 1;
            this.richTextBoxMostrarProductos.Text = "";
            // 
            // btnBuscarProductos
            // 
            this.btnBuscarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProductos.Location = new System.Drawing.Point(6, 19);
            this.btnBuscarProductos.Name = "btnBuscarProductos";
            this.btnBuscarProductos.Size = new System.Drawing.Size(188, 35);
            this.btnBuscarProductos.TabIndex = 4;
            this.btnBuscarProductos.Text = "Buscar Productos";
            this.btnBuscarProductos.UseVisualStyleBackColor = true;
            this.btnBuscarProductos.Click += new System.EventHandler(this.btnBuscarProductos_Click);
            // 
            // groupBoxCompras
            // 
            this.groupBoxCompras.Controls.Add(this.btnBuscarProductos);
            this.groupBoxCompras.Controls.Add(this.btnMostrarProductos);
            this.groupBoxCompras.Controls.Add(this.btnCarrito);
            this.groupBoxCompras.Location = new System.Drawing.Point(6, 19);
            this.groupBoxCompras.Name = "groupBoxCompras";
            this.groupBoxCompras.Size = new System.Drawing.Size(197, 188);
            this.groupBoxCompras.TabIndex = 5;
            this.groupBoxCompras.TabStop = false;
            // 
            // groupBoxInventario
            // 
            this.groupBoxInventario.Controls.Add(this.btnAltaProducto);
            this.groupBoxInventario.Controls.Add(this.btnInventario);
            this.groupBoxInventario.Location = new System.Drawing.Point(6, 213);
            this.groupBoxInventario.Name = "groupBoxInventario";
            this.groupBoxInventario.Size = new System.Drawing.Size(197, 188);
            this.groupBoxInventario.TabIndex = 6;
            this.groupBoxInventario.TabStop = false;
            // 
            // btnInventario
            // 
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Location = new System.Drawing.Point(6, 30);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(185, 46);
            this.btnInventario.TabIndex = 0;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnAltaProducto
            // 
            this.btnAltaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaProducto.Location = new System.Drawing.Point(6, 93);
            this.btnAltaProducto.Name = "btnAltaProducto";
            this.btnAltaProducto.Size = new System.Drawing.Size(185, 46);
            this.btnAltaProducto.TabIndex = 1;
            this.btnAltaProducto.Text = "Alta de Producto";
            this.btnAltaProducto.UseVisualStyleBackColor = true;
            this.btnAltaProducto.Click += new System.EventHandler(this.btnAltaProducto_Click);
            // 
            // btnCarrito
            // 
            this.btnCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrito.Image = global::Ferreteria_Form.Properties.Resources.carrito2;
            this.btnCarrito.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCarrito.Location = new System.Drawing.Point(6, 97);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(188, 74);
            this.btnCarrito.TabIndex = 2;
            this.btnCarrito.Text = "Carrito";
            this.btnCarrito.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCarrito.UseVisualStyleBackColor = true;
            this.btnCarrito.Click += new System.EventHandler(this.btnCarrito_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.groupBoxUsuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ferreteria de Javier Magdaleno";
            //this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBoxUsuario.ResumeLayout(false);
            this.groupBoxCompras.ResumeLayout(false);
            this.groupBoxInventario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUsuario;
        private System.Windows.Forms.RichTextBox richTextBoxMostrarProductos;
        private System.Windows.Forms.Button btnMostrarProductos;
        private System.Windows.Forms.Button btnCarrito;
        private System.Windows.Forms.Button btnBuscarProductos;
        private System.Windows.Forms.GroupBox groupBoxInventario;
        private System.Windows.Forms.Button btnAltaProducto;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.GroupBox groupBoxCompras;
    }
}
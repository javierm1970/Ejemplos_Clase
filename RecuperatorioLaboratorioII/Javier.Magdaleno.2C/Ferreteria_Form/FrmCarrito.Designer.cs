namespace Ferreteria_Form
{
    partial class FrmCarrito
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
            this.groupBoxCarrito = new System.Windows.Forms.GroupBox();
            this.groupBoxListarPedidos = new System.Windows.Forms.GroupBox();
            this.richTextBoxPedidos = new System.Windows.Forms.RichTextBox();
            this.groupBoxListaProducto = new System.Windows.Forms.GroupBox();
            this.richTextBoxProductos = new System.Windows.Forms.RichTextBox();
            this.groupBoxCompra = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.lblQuitar = new System.Windows.Forms.Label();
            this.groupBoxProducto = new System.Windows.Forms.GroupBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.comboBoxTipoAmbito = new System.Windows.Forms.ComboBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.comboBoxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblTipoAmbito = new System.Windows.Forms.Label();
            this.groupBoxCarrito.SuspendLayout();
            this.groupBoxListarPedidos.SuspendLayout();
            this.groupBoxListaProducto.SuspendLayout();
            this.groupBoxCompra.SuspendLayout();
            this.groupBoxProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCarrito
            // 
            this.groupBoxCarrito.Controls.Add(this.groupBoxListarPedidos);
            this.groupBoxCarrito.Controls.Add(this.groupBoxListaProducto);
            this.groupBoxCarrito.Controls.Add(this.groupBoxCompra);
            this.groupBoxCarrito.Controls.Add(this.groupBoxProducto);
            this.groupBoxCarrito.Location = new System.Drawing.Point(18, 17);
            this.groupBoxCarrito.Name = "groupBoxCarrito";
            this.groupBoxCarrito.Size = new System.Drawing.Size(1061, 409);
            this.groupBoxCarrito.TabIndex = 0;
            this.groupBoxCarrito.TabStop = false;
            this.groupBoxCarrito.Text = "Carrito";
            // 
            // groupBoxListarPedidos
            // 
            this.groupBoxListarPedidos.Controls.Add(this.richTextBoxPedidos);
            this.groupBoxListarPedidos.Location = new System.Drawing.Point(735, 19);
            this.groupBoxListarPedidos.Name = "groupBoxListarPedidos";
            this.groupBoxListarPedidos.Size = new System.Drawing.Size(320, 370);
            this.groupBoxListarPedidos.TabIndex = 12;
            this.groupBoxListarPedidos.TabStop = false;
            this.groupBoxListarPedidos.Text = "Lista de Pedidos";
            // 
            // richTextBoxPedidos
            // 
            this.richTextBoxPedidos.Location = new System.Drawing.Point(13, 19);
            this.richTextBoxPedidos.Name = "richTextBoxPedidos";
            this.richTextBoxPedidos.Size = new System.Drawing.Size(307, 341);
            this.richTextBoxPedidos.TabIndex = 0;
            this.richTextBoxPedidos.Text = "";
            // 
            // groupBoxListaProducto
            // 
            this.groupBoxListaProducto.Controls.Add(this.richTextBoxProductos);
            this.groupBoxListaProducto.Location = new System.Drawing.Point(410, 19);
            this.groupBoxListaProducto.Name = "groupBoxListaProducto";
            this.groupBoxListaProducto.Size = new System.Drawing.Size(319, 370);
            this.groupBoxListaProducto.TabIndex = 15;
            this.groupBoxListaProducto.TabStop = false;
            this.groupBoxListaProducto.Text = "Lista de Productos";
            // 
            // richTextBoxProductos
            // 
            this.richTextBoxProductos.Location = new System.Drawing.Point(10, 19);
            this.richTextBoxProductos.Name = "richTextBoxProductos";
            this.richTextBoxProductos.Size = new System.Drawing.Size(303, 341);
            this.richTextBoxProductos.TabIndex = 11;
            this.richTextBoxProductos.Text = "";
            // 
            // groupBoxCompra
            // 
            this.groupBoxCompra.Controls.Add(this.btnAgregar);
            this.groupBoxCompra.Controls.Add(this.btnQuitar);
            this.groupBoxCompra.Controls.Add(this.btnComprar);
            this.groupBoxCompra.Controls.Add(this.lblAgregar);
            this.groupBoxCompra.Controls.Add(this.lblQuitar);
            this.groupBoxCompra.Location = new System.Drawing.Point(6, 200);
            this.groupBoxCompra.Name = "groupBoxCompra";
            this.groupBoxCompra.Size = new System.Drawing.Size(367, 189);
            this.groupBoxCompra.TabIndex = 14;
            this.groupBoxCompra.TabStop = false;
            this.groupBoxCompra.Text = "Compra";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Ferreteria_Form.Properties.Resources.carritoOk1;
            this.btnAgregar.Location = new System.Drawing.Point(79, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 63);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Image = global::Ferreteria_Form.Properties.Resources.carritoX;
            this.btnQuitar.Location = new System.Drawing.Point(203, 29);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 63);
            this.btnQuitar.TabIndex = 2;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Location = new System.Drawing.Point(118, 131);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(117, 38);
            this.btnComprar.TabIndex = 12;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lblAgregar
            // 
            this.lblAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregar.Location = new System.Drawing.Point(88, 95);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(63, 23);
            this.lblAgregar.TabIndex = 3;
            this.lblAgregar.Text = "Agregar";
            // 
            // lblQuitar
            // 
            this.lblQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuitar.Location = new System.Drawing.Point(215, 95);
            this.lblQuitar.Name = "lblQuitar";
            this.lblQuitar.Size = new System.Drawing.Size(63, 23);
            this.lblQuitar.TabIndex = 4;
            this.lblQuitar.Text = "Quitar";
            // 
            // groupBoxProducto
            // 
            this.groupBoxProducto.Controls.Add(this.lblDescripcion);
            this.groupBoxProducto.Controls.Add(this.textBoxDescripcion);
            this.groupBoxProducto.Controls.Add(this.comboBoxTipoAmbito);
            this.groupBoxProducto.Controls.Add(this.lblTipoUsuario);
            this.groupBoxProducto.Controls.Add(this.comboBoxTipoUsuario);
            this.groupBoxProducto.Controls.Add(this.lblTipoAmbito);
            this.groupBoxProducto.Location = new System.Drawing.Point(6, 30);
            this.groupBoxProducto.Name = "groupBoxProducto";
            this.groupBoxProducto.Size = new System.Drawing.Size(367, 164);
            this.groupBoxProducto.TabIndex = 13;
            this.groupBoxProducto.TabStop = false;
            this.groupBoxProducto.Text = "Producto";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(15, 26);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(67, 23);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripción";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(88, 26);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(266, 20);
            this.textBoxDescripcion.TabIndex = 5;
            // 
            // comboBoxTipoAmbito
            // 
            this.comboBoxTipoAmbito.FormattingEnabled = true;
            this.comboBoxTipoAmbito.Location = new System.Drawing.Point(88, 70);
            this.comboBoxTipoAmbito.Name = "comboBoxTipoAmbito";
            this.comboBoxTipoAmbito.Size = new System.Drawing.Size(266, 21);
            this.comboBoxTipoAmbito.TabIndex = 6;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.Location = new System.Drawing.Point(15, 116);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(67, 23);
            this.lblTipoUsuario.TabIndex = 10;
            this.lblTipoUsuario.Text = "Tipo Usuario";
            // 
            // comboBoxTipoUsuario
            // 
            this.comboBoxTipoUsuario.FormattingEnabled = true;
            this.comboBoxTipoUsuario.Location = new System.Drawing.Point(88, 116);
            this.comboBoxTipoUsuario.Name = "comboBoxTipoUsuario";
            this.comboBoxTipoUsuario.Size = new System.Drawing.Size(266, 21);
            this.comboBoxTipoUsuario.TabIndex = 7;
            // 
            // lblTipoAmbito
            // 
            this.lblTipoAmbito.Location = new System.Drawing.Point(15, 70);
            this.lblTipoAmbito.Name = "lblTipoAmbito";
            this.lblTipoAmbito.Size = new System.Drawing.Size(67, 23);
            this.lblTipoAmbito.TabIndex = 9;
            this.lblTipoAmbito.Text = "Tipo Ambito";
            // 
            // FrmCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 450);
            this.Controls.Add(this.groupBoxCarrito);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCarrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrito de Compras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCarrito_FormClosing);
            //this.Load += new System.EventHandler(this.FrmCarrito_Load);
            this.groupBoxCarrito.ResumeLayout(false);
            this.groupBoxListarPedidos.ResumeLayout(false);
            this.groupBoxListaProducto.ResumeLayout(false);
            this.groupBoxCompra.ResumeLayout(false);
            this.groupBoxProducto.ResumeLayout(false);
            this.groupBoxProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCarrito;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RichTextBox richTextBoxPedidos;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Label lblTipoAmbito;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox comboBoxTipoUsuario;
        private System.Windows.Forms.ComboBox comboBoxTipoAmbito;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label lblQuitar;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.RichTextBox richTextBoxProductos;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.GroupBox groupBoxListarPedidos;
        private System.Windows.Forms.GroupBox groupBoxListaProducto;
        private System.Windows.Forms.GroupBox groupBoxCompra;
        private System.Windows.Forms.GroupBox groupBoxProducto;
    }
}
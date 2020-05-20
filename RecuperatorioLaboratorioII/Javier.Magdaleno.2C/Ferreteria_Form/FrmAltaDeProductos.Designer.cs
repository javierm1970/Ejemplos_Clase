namespace Ferreteria_Form
{
    partial class FrmAltaDeProductos
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
            this.groupBoxProducto = new System.Windows.Forms.GroupBox();
            this.radioButtonMateriales = new System.Windows.Forms.RadioButton();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.lblTipoAmbito = new System.Windows.Forms.Label();
            this.radioButtonHerramientas = new System.Windows.Forms.RadioButton();
            this.radioButtonBuloneria = new System.Windows.Forms.RadioButton();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.comboBoxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoAmbito = new System.Windows.Forms.ComboBox();
            this.groupBoxBuloneria = new System.Windows.Forms.GroupBox();
            this.lblTipoRosca = new System.Windows.Forms.Label();
            this.lblDiametro = new System.Windows.Forms.Label();
            this.lblLargo = new System.Windows.Forms.Label();
            this.textBoxDiametro = new System.Windows.Forms.TextBox();
            this.textBoxLargo = new System.Windows.Forms.TextBox();
            this.comboBoxTipoRosca = new System.Windows.Forms.ComboBox();
            this.groupBoxHerramientas = new System.Windows.Forms.GroupBox();
            this.lblTipoManual = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.comboBoxTipoManual = new System.Windows.Forms.ComboBox();
            this.groupBoxMateriales = new System.Windows.Forms.GroupBox();
            this.lblVoltaje = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.checkBoxEsArtefacto = new System.Windows.Forms.CheckBox();
            this.textBoxVoltaje = new System.Windows.Forms.TextBox();
            this.textBoxOrigen = new System.Windows.Forms.TextBox();
            this.groupBoxGrabar = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.groupBoxProducto.SuspendLayout();
            this.groupBoxBuloneria.SuspendLayout();
            this.groupBoxHerramientas.SuspendLayout();
            this.groupBoxMateriales.SuspendLayout();
            this.groupBoxGrabar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxProducto
            // 
            this.groupBoxProducto.Controls.Add(this.radioButtonMateriales);
            this.groupBoxProducto.Controls.Add(this.lblTipoUsuario);
            this.groupBoxProducto.Controls.Add(this.lblTipoAmbito);
            this.groupBoxProducto.Controls.Add(this.radioButtonHerramientas);
            this.groupBoxProducto.Controls.Add(this.radioButtonBuloneria);
            this.groupBoxProducto.Controls.Add(this.lblStock);
            this.groupBoxProducto.Controls.Add(this.lblPrecio);
            this.groupBoxProducto.Controls.Add(this.lblDescripcion);
            this.groupBoxProducto.Controls.Add(this.lblCodigo);
            this.groupBoxProducto.Controls.Add(this.textBoxStock);
            this.groupBoxProducto.Controls.Add(this.textBoxPrecio);
            this.groupBoxProducto.Controls.Add(this.textBoxDescripcion);
            this.groupBoxProducto.Controls.Add(this.textBoxCodigo);
            this.groupBoxProducto.Controls.Add(this.comboBoxTipoUsuario);
            this.groupBoxProducto.Controls.Add(this.comboBoxTipoAmbito);
            this.groupBoxProducto.Location = new System.Drawing.Point(11, 9);
            this.groupBoxProducto.Name = "groupBoxProducto";
            this.groupBoxProducto.Size = new System.Drawing.Size(486, 162);
            this.groupBoxProducto.TabIndex = 0;
            this.groupBoxProducto.TabStop = false;
            this.groupBoxProducto.Text = "Producto";
            // 
            // radioButtonMateriales
            // 
            this.radioButtonMateriales.AutoSize = true;
            this.radioButtonMateriales.Location = new System.Drawing.Point(286, 75);
            this.radioButtonMateriales.Name = "radioButtonMateriales";
            this.radioButtonMateriales.Size = new System.Drawing.Size(122, 17);
            this.radioButtonMateriales.TabIndex = 6;
            this.radioButtonMateriales.TabStop = true;
            this.radioButtonMateriales.Text = "Materiales Eléctricos";
            this.radioButtonMateriales.UseVisualStyleBackColor = true;
            this.radioButtonMateriales.CheckedChanged += new System.EventHandler(this.radioButtonMateriales_CheckedChanged);
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.Location = new System.Drawing.Point(369, 106);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(100, 23);
            this.lblTipoUsuario.TabIndex = 10;
            this.lblTipoUsuario.Text = "Tipo Usuario";
            // 
            // lblTipoAmbito
            // 
            this.lblTipoAmbito.Location = new System.Drawing.Point(223, 106);
            this.lblTipoAmbito.Name = "lblTipoAmbito";
            this.lblTipoAmbito.Size = new System.Drawing.Size(100, 23);
            this.lblTipoAmbito.TabIndex = 9;
            this.lblTipoAmbito.Text = "Tipo Ambito";
            // 
            // radioButtonHerramientas
            // 
            this.radioButtonHerramientas.AutoSize = true;
            this.radioButtonHerramientas.Location = new System.Drawing.Point(286, 52);
            this.radioButtonHerramientas.Name = "radioButtonHerramientas";
            this.radioButtonHerramientas.Size = new System.Drawing.Size(136, 17);
            this.radioButtonHerramientas.TabIndex = 5;
            this.radioButtonHerramientas.TabStop = true;
            this.radioButtonHerramientas.Text = "Herramientas Eléctricas";
            this.radioButtonHerramientas.UseVisualStyleBackColor = true;
            this.radioButtonHerramientas.CheckedChanged += new System.EventHandler(this.radioButtonHerramientas_CheckedChanged);
            // 
            // radioButtonBuloneria
            // 
            this.radioButtonBuloneria.AutoSize = true;
            this.radioButtonBuloneria.Location = new System.Drawing.Point(286, 29);
            this.radioButtonBuloneria.Name = "radioButtonBuloneria";
            this.radioButtonBuloneria.Size = new System.Drawing.Size(71, 17);
            this.radioButtonBuloneria.TabIndex = 4;
            this.radioButtonBuloneria.TabStop = true;
            this.radioButtonBuloneria.Text = "Bulonería";
            this.radioButtonBuloneria.UseVisualStyleBackColor = true;
            this.radioButtonBuloneria.CheckedChanged += new System.EventHandler(this.radioButtonBuloneria_CheckedChanged);
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(7, 130);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(66, 23);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Location = new System.Drawing.Point(7, 98);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(66, 23);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(7, 60);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 23);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(7, 23);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(66, 23);
            this.lblCodigo.TabIndex = 15;
            this.lblCodigo.Text = "Codigo";
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(77, 133);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(100, 20);
            this.textBoxStock.TabIndex = 3;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(77, 98);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecio.TabIndex = 2;
            //this.textBoxPrecio.TextChanged += new System.EventHandler(this.textBoxPrecio_TextChanged);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(77, 63);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescripcion.TabIndex = 1;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(77, 25);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 0;
            // 
            // comboBoxTipoUsuario
            // 
            this.comboBoxTipoUsuario.FormattingEnabled = true;
            this.comboBoxTipoUsuario.ItemHeight = 13;
            this.comboBoxTipoUsuario.Location = new System.Drawing.Point(348, 132);
            this.comboBoxTipoUsuario.Name = "comboBoxTipoUsuario";
            this.comboBoxTipoUsuario.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoUsuario.TabIndex = 8;
            // 
            // comboBoxTipoAmbito
            // 
            this.comboBoxTipoAmbito.FormattingEnabled = true;
            this.comboBoxTipoAmbito.ItemHeight = 13;
            this.comboBoxTipoAmbito.Location = new System.Drawing.Point(202, 132);
            this.comboBoxTipoAmbito.Name = "comboBoxTipoAmbito";
            this.comboBoxTipoAmbito.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoAmbito.TabIndex = 7;
            // 
            // groupBoxBuloneria
            // 
            this.groupBoxBuloneria.Controls.Add(this.lblTipoRosca);
            this.groupBoxBuloneria.Controls.Add(this.lblDiametro);
            this.groupBoxBuloneria.Controls.Add(this.lblLargo);
            this.groupBoxBuloneria.Controls.Add(this.textBoxDiametro);
            this.groupBoxBuloneria.Controls.Add(this.textBoxLargo);
            this.groupBoxBuloneria.Controls.Add(this.comboBoxTipoRosca);
            this.groupBoxBuloneria.Location = new System.Drawing.Point(11, 177);
            this.groupBoxBuloneria.Name = "groupBoxBuloneria";
            this.groupBoxBuloneria.Size = new System.Drawing.Size(486, 95);
            this.groupBoxBuloneria.TabIndex = 0;
            this.groupBoxBuloneria.TabStop = false;
            this.groupBoxBuloneria.Text = "Bulonería";
            // 
            // lblTipoRosca
            // 
            this.lblTipoRosca.Location = new System.Drawing.Point(223, 30);
            this.lblTipoRosca.Name = "lblTipoRosca";
            this.lblTipoRosca.Size = new System.Drawing.Size(100, 23);
            this.lblTipoRosca.TabIndex = 5;
            this.lblTipoRosca.Text = "Tipo de Rosca";
            // 
            // lblDiametro
            // 
            this.lblDiametro.Location = new System.Drawing.Point(7, 60);
            this.lblDiametro.Name = "lblDiametro";
            this.lblDiametro.Size = new System.Drawing.Size(66, 23);
            this.lblDiametro.TabIndex = 4;
            this.lblDiametro.Text = "Diámetro";
            // 
            // lblLargo
            // 
            this.lblLargo.Location = new System.Drawing.Point(7, 27);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(66, 23);
            this.lblLargo.TabIndex = 3;
            this.lblLargo.Text = "Largo";
            // 
            // textBoxDiametro
            // 
            this.textBoxDiametro.Location = new System.Drawing.Point(77, 57);
            this.textBoxDiametro.Name = "textBoxDiametro";
            this.textBoxDiametro.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiametro.TabIndex = 1;
            // 
            // textBoxLargo
            // 
            this.textBoxLargo.Location = new System.Drawing.Point(77, 20);
            this.textBoxLargo.Name = "textBoxLargo";
            this.textBoxLargo.Size = new System.Drawing.Size(100, 20);
            this.textBoxLargo.TabIndex = 0;
            // 
            // comboBoxTipoRosca
            // 
            this.comboBoxTipoRosca.FormattingEnabled = true;
            this.comboBoxTipoRosca.Location = new System.Drawing.Point(202, 56);
            this.comboBoxTipoRosca.Name = "comboBoxTipoRosca";
            this.comboBoxTipoRosca.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoRosca.TabIndex = 2;
            // 
            // groupBoxHerramientas
            // 
            this.groupBoxHerramientas.Controls.Add(this.lblTipoManual);
            this.groupBoxHerramientas.Controls.Add(this.lblPeso);
            this.groupBoxHerramientas.Controls.Add(this.textBoxPeso);
            this.groupBoxHerramientas.Controls.Add(this.comboBoxTipoManual);
            this.groupBoxHerramientas.Location = new System.Drawing.Point(11, 278);
            this.groupBoxHerramientas.Name = "groupBoxHerramientas";
            this.groupBoxHerramientas.Size = new System.Drawing.Size(486, 81);
            this.groupBoxHerramientas.TabIndex = 0;
            this.groupBoxHerramientas.TabStop = false;
            this.groupBoxHerramientas.Text = "Herramientas Eléctricas";
            // 
            // lblTipoManual
            // 
            this.lblTipoManual.Location = new System.Drawing.Point(223, 15);
            this.lblTipoManual.Name = "lblTipoManual";
            this.lblTipoManual.Size = new System.Drawing.Size(100, 23);
            this.lblTipoManual.TabIndex = 4;
            this.lblTipoManual.Text = "Tipo de Manual";
            // 
            // lblPeso
            // 
            this.lblPeso.Location = new System.Drawing.Point(7, 44);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(66, 23);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.Text = "Peso";
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(77, 41);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(100, 20);
            this.textBoxPeso.TabIndex = 0;
            // 
            // comboBoxTipoManual
            // 
            this.comboBoxTipoManual.FormattingEnabled = true;
            this.comboBoxTipoManual.Location = new System.Drawing.Point(202, 41);
            this.comboBoxTipoManual.Name = "comboBoxTipoManual";
            this.comboBoxTipoManual.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoManual.TabIndex = 2;
            // 
            // groupBoxMateriales
            // 
            this.groupBoxMateriales.Controls.Add(this.lblVoltaje);
            this.groupBoxMateriales.Controls.Add(this.lblOrigen);
            this.groupBoxMateriales.Controls.Add(this.checkBoxEsArtefacto);
            this.groupBoxMateriales.Controls.Add(this.textBoxVoltaje);
            this.groupBoxMateriales.Controls.Add(this.textBoxOrigen);
            this.groupBoxMateriales.Location = new System.Drawing.Point(11, 365);
            this.groupBoxMateriales.Name = "groupBoxMateriales";
            this.groupBoxMateriales.Size = new System.Drawing.Size(486, 105);
            this.groupBoxMateriales.TabIndex = 0;
            this.groupBoxMateriales.TabStop = false;
            this.groupBoxMateriales.Text = "Materiales Eléctricos";
            // 
            // lblVoltaje
            // 
            this.lblVoltaje.Location = new System.Drawing.Point(7, 72);
            this.lblVoltaje.Name = "lblVoltaje";
            this.lblVoltaje.Size = new System.Drawing.Size(66, 23);
            this.lblVoltaje.TabIndex = 4;
            this.lblVoltaje.Text = "Voltaje";
            // 
            // lblOrigen
            // 
            this.lblOrigen.Location = new System.Drawing.Point(7, 39);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(66, 23);
            this.lblOrigen.TabIndex = 3;
            this.lblOrigen.Text = "Made in";
            // 
            // checkBoxEsArtefacto
            // 
            this.checkBoxEsArtefacto.AutoSize = true;
            this.checkBoxEsArtefacto.Location = new System.Drawing.Point(286, 35);
            this.checkBoxEsArtefacto.Name = "checkBoxEsArtefacto";
            this.checkBoxEsArtefacto.Size = new System.Drawing.Size(105, 17);
            this.checkBoxEsArtefacto.TabIndex = 2;
            this.checkBoxEsArtefacto.Text = "Es un Artefacto?";
            this.checkBoxEsArtefacto.UseVisualStyleBackColor = true;
            // 
            // textBoxVoltaje
            // 
            this.textBoxVoltaje.Location = new System.Drawing.Point(77, 69);
            this.textBoxVoltaje.Name = "textBoxVoltaje";
            this.textBoxVoltaje.Size = new System.Drawing.Size(100, 20);
            this.textBoxVoltaje.TabIndex = 1;
            // 
            // textBoxOrigen
            // 
            this.textBoxOrigen.Location = new System.Drawing.Point(77, 32);
            this.textBoxOrigen.Name = "textBoxOrigen";
            this.textBoxOrigen.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrigen.TabIndex = 0;
            // 
            // groupBoxGrabar
            // 
            this.groupBoxGrabar.Controls.Add(this.btnSalir);
            this.groupBoxGrabar.Controls.Add(this.btnGrabar);
            this.groupBoxGrabar.Location = new System.Drawing.Point(12, 476);
            this.groupBoxGrabar.Name = "groupBoxGrabar";
            this.groupBoxGrabar.Size = new System.Drawing.Size(484, 62);
            this.groupBoxGrabar.TabIndex = 1;
            this.groupBoxGrabar.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(251, 19);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 34);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(90, 19);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(125, 34);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // FrmAltaDeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 541);
            this.Controls.Add(this.groupBoxGrabar);
            this.Controls.Add(this.groupBoxMateriales);
            this.Controls.Add(this.groupBoxHerramientas);
            this.Controls.Add(this.groupBoxBuloneria);
            this.Controls.Add(this.groupBoxProducto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAltaDeProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAltaDeProductos_FormClosing);
            this.groupBoxProducto.ResumeLayout(false);
            this.groupBoxProducto.PerformLayout();
            this.groupBoxBuloneria.ResumeLayout(false);
            this.groupBoxBuloneria.PerformLayout();
            this.groupBoxHerramientas.ResumeLayout(false);
            this.groupBoxHerramientas.PerformLayout();
            this.groupBoxMateriales.ResumeLayout(false);
            this.groupBoxMateriales.PerformLayout();
            this.groupBoxGrabar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProducto;
        private System.Windows.Forms.ComboBox comboBoxTipoUsuario;
        private System.Windows.Forms.ComboBox comboBoxTipoAmbito;
        private System.Windows.Forms.GroupBox groupBoxBuloneria;
        private System.Windows.Forms.ComboBox comboBoxTipoRosca;
        private System.Windows.Forms.GroupBox groupBoxHerramientas;
        private System.Windows.Forms.GroupBox groupBoxMateriales;
        private System.Windows.Forms.ComboBox comboBoxTipoManual;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.RadioButton radioButtonMateriales;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Label lblTipoAmbito;
        private System.Windows.Forms.RadioButton radioButtonHerramientas;
        private System.Windows.Forms.RadioButton radioButtonBuloneria;
        private System.Windows.Forms.Label lblTipoRosca;
        private System.Windows.Forms.Label lblDiametro;
        private System.Windows.Forms.Label lblLargo;
        private System.Windows.Forms.TextBox textBoxDiametro;
        private System.Windows.Forms.TextBox textBoxLargo;
        private System.Windows.Forms.Label lblTipoManual;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.TextBox textBoxVoltaje;
        private System.Windows.Forms.TextBox textBoxOrigen;
        private System.Windows.Forms.Label lblVoltaje;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.CheckBox checkBoxEsArtefacto;
        private System.Windows.Forms.GroupBox groupBoxGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGrabar;
    }
}
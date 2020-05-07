namespace VistaForm
{
    partial class FormDT
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblExperiencia = new System.Windows.Forms.Label();
            this.numUDEdad = new System.Windows.Forms.NumericUpDown();
            this.numUDDni = new System.Windows.Forms.NumericUpDown();
            this.numUDExperiencia = new System.Windows.Forms.NumericUpDown();
            this.IContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numUDEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDExperiencia)).BeginInit();
            this.IContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(166, 16);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(120, 20);
            this.textBoxNombre.TabIndex = 0;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(166, 52);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(120, 20);
            this.textBoxApellido.TabIndex = 1;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(53, 229);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(103, 40);
            this.btnCrear.TabIndex = 5;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(191, 229);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(103, 40);
            this.btnValidar.TabIndex = 6;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(60, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 23);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(60, 52);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(100, 23);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblEdad
            // 
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(60, 99);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(100, 23);
            this.lblEdad.TabIndex = 9;
            this.lblEdad.Text = "Edad:";
            // 
            // lblDni
            // 
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(60, 141);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(100, 23);
            this.lblDni.TabIndex = 10;
            this.lblDni.Text = "Dni:";
            // 
            // lblExperiencia
            // 
            this.lblExperiencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperiencia.Location = new System.Drawing.Point(60, 185);
            this.lblExperiencia.Name = "lblExperiencia";
            this.lblExperiencia.Size = new System.Drawing.Size(100, 23);
            this.lblExperiencia.TabIndex = 11;
            this.lblExperiencia.Text = "Experiencia:";
            // 
            // numUDEdad
            // 
            this.numUDEdad.Location = new System.Drawing.Point(166, 99);
            this.numUDEdad.Name = "numUDEdad";
            this.numUDEdad.Size = new System.Drawing.Size(120, 20);
            this.numUDEdad.TabIndex = 12;
            this.numUDEdad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUDDni
            // 
            this.numUDDni.Location = new System.Drawing.Point(166, 141);
            this.numUDDni.Name = "numUDDni";
            this.numUDDni.Size = new System.Drawing.Size(120, 20);
            this.numUDDni.TabIndex = 13;
            this.numUDDni.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUDExperiencia
            // 
            this.numUDExperiencia.Location = new System.Drawing.Point(166, 185);
            this.numUDExperiencia.Name = "numUDExperiencia";
            this.numUDExperiencia.Size = new System.Drawing.Size(120, 20);
            this.numUDExperiencia.TabIndex = 14;
            this.numUDExperiencia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // IContainer
            // 
            this.IContainer.Controls.Add(this.lblNombre);
            this.IContainer.Controls.Add(this.numUDExperiencia);
            this.IContainer.Controls.Add(this.textBoxNombre);
            this.IContainer.Controls.Add(this.numUDDni);
            this.IContainer.Controls.Add(this.textBoxApellido);
            this.IContainer.Controls.Add(this.numUDEdad);
            this.IContainer.Controls.Add(this.btnCrear);
            this.IContainer.Controls.Add(this.lblExperiencia);
            this.IContainer.Controls.Add(this.btnValidar);
            this.IContainer.Controls.Add(this.lblDni);
            this.IContainer.Controls.Add(this.lblApellido);
            this.IContainer.Controls.Add(this.lblEdad);
            this.IContainer.Location = new System.Drawing.Point(15, 11);
            this.IContainer.Name = "IContainer";
            this.IContainer.Size = new System.Drawing.Size(356, 299);
            this.IContainer.TabIndex = 15;
            // 
            // FormDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 322);
            this.Controls.Add(this.IContainer);
            this.Name = "FormDT";
            this.Text = "FormDT";
            this.Load += new System.EventHandler(this.FormDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDExperiencia)).EndInit();
            this.IContainer.ResumeLayout(false);
            this.IContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblExperiencia;
        private System.Windows.Forms.NumericUpDown numUDEdad;
        private System.Windows.Forms.NumericUpDown numUDDni;
        private System.Windows.Forms.NumericUpDown numUDExperiencia;
        private System.Windows.Forms.Panel IContainer;
    }
}


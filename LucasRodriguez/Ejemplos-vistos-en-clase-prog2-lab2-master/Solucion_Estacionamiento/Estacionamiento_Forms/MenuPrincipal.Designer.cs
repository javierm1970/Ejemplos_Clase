﻿namespace Estacionamiento_Forms
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estacionamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGrid_ListaAutos = new System.Windows.Forms.DataGridView();
            this.Patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantPuertas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.lb_nombreEstacionamiento = new System.Windows.Forms.Label();
            this.lb_capacidad = new System.Windows.Forms.Label();
            this.lb_precioPorDia = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ListaAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estacionamientoToolStripMenuItem,
            this.funcionesToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estacionamientoToolStripMenuItem
            // 
            this.estacionamientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem});
            this.estacionamientoToolStripMenuItem.Name = "estacionamientoToolStripMenuItem";
            this.estacionamientoToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.estacionamientoToolStripMenuItem.Text = "Configuracion";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.configuraciónToolStripMenuItem.Text = "Configurar informacion garage";
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.configuraciónToolStripMenuItem_Click);
            // 
            // funcionesToolStripMenuItem
            // 
            this.funcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAutoToolStripMenuItem});
            this.funcionesToolStripMenuItem.Name = "funcionesToolStripMenuItem";
            this.funcionesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.funcionesToolStripMenuItem.Text = "Funciones";
            // 
            // agregarAutoToolStripMenuItem
            // 
            this.agregarAutoToolStripMenuItem.Name = "agregarAutoToolStripMenuItem";
            this.agregarAutoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.agregarAutoToolStripMenuItem.Text = "Agregar auto";
            this.agregarAutoToolStripMenuItem.Click += new System.EventHandler(this.agregarAutoToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.opcionesToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // dataGrid_ListaAutos
            // 
            this.dataGrid_ListaAutos.AllowUserToAddRows = false;
            this.dataGrid_ListaAutos.AllowUserToDeleteRows = false;
            this.dataGrid_ListaAutos.AllowUserToResizeColumns = false;
            this.dataGrid_ListaAutos.AllowUserToResizeRows = false;
            this.dataGrid_ListaAutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_ListaAutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGrid_ListaAutos.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGrid_ListaAutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid_ListaAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_ListaAutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Patente,
            this.Dni,
            this.Marca,
            this.CantPuertas});
            this.dataGrid_ListaAutos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGrid_ListaAutos.Location = new System.Drawing.Point(0, 173);
            this.dataGrid_ListaAutos.Name = "dataGrid_ListaAutos";
            this.dataGrid_ListaAutos.Size = new System.Drawing.Size(644, 185);
            this.dataGrid_ListaAutos.TabIndex = 1;
            // 
            // Patente
            // 
            this.Patente.HeaderText = "Patente";
            this.Patente.Name = "Patente";
            this.Patente.ReadOnly = true;
            // 
            // Dni
            // 
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // CantPuertas
            // 
            this.CantPuertas.HeaderText = "Cantidad de puertas";
            this.CantPuertas.Name = "CantPuertas";
            this.CantPuertas.ReadOnly = true;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.Green;
            this.lb_titulo.Location = new System.Drawing.Point(85, 33);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(379, 25);
            this.lb_titulo.TabIndex = 2;
            this.lb_titulo.Text = "Bienvenidos al gestor de Estacionamiento ";
            // 
            // lb_nombreEstacionamiento
            // 
            this.lb_nombreEstacionamiento.AutoSize = true;
            this.lb_nombreEstacionamiento.BackColor = System.Drawing.Color.Black;
            this.lb_nombreEstacionamiento.ForeColor = System.Drawing.Color.Green;
            this.lb_nombreEstacionamiento.Location = new System.Drawing.Point(31, 86);
            this.lb_nombreEstacionamiento.Name = "lb_nombreEstacionamiento";
            this.lb_nombreEstacionamiento.Size = new System.Drawing.Size(134, 13);
            this.lb_nombreEstacionamiento.TabIndex = 3;
            this.lb_nombreEstacionamiento.Text = "lb_nombreEstacionamiento";
            // 
            // lb_capacidad
            // 
            this.lb_capacidad.AutoSize = true;
            this.lb_capacidad.BackColor = System.Drawing.Color.Black;
            this.lb_capacidad.ForeColor = System.Drawing.Color.Green;
            this.lb_capacidad.Location = new System.Drawing.Point(31, 114);
            this.lb_capacidad.Name = "lb_capacidad";
            this.lb_capacidad.Size = new System.Drawing.Size(71, 13);
            this.lb_capacidad.TabIndex = 4;
            this.lb_capacidad.Text = "lb_capacidad";
            // 
            // lb_precioPorDia
            // 
            this.lb_precioPorDia.AutoSize = true;
            this.lb_precioPorDia.BackColor = System.Drawing.Color.Black;
            this.lb_precioPorDia.ForeColor = System.Drawing.Color.Green;
            this.lb_precioPorDia.Location = new System.Drawing.Point(31, 144);
            this.lb_precioPorDia.Name = "lb_precioPorDia";
            this.lb_precioPorDia.Size = new System.Drawing.Size(82, 13);
            this.lb_precioPorDia.TabIndex = 5;
            this.lb_precioPorDia.Text = "lb_precioPorDia";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(644, 357);
            this.Controls.Add(this.lb_precioPorDia);
            this.Controls.Add(this.lb_capacidad);
            this.Controls.Add(this.lb_nombreEstacionamiento);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.dataGrid_ListaAutos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ListaAutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estacionamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGrid_ListaAutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantPuertas;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Label lb_nombreEstacionamiento;
        private System.Windows.Forms.Label lb_capacidad;
        private System.Windows.Forms.Label lb_precioPorDia;
    }
}
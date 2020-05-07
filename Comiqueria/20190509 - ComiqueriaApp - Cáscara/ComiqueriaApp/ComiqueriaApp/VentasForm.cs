using ComiqueriaLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        private string descripcion;
        private double precio;
        private int stock;
        private Producto producto;
        private Comiqueria comiqueria;
        public VentasForm()
        {
            InitializeComponent();
        }
        public VentasForm(string descripcion, double precio,int stock,Producto producto,Comiqueria comiqueria):this()
        {
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
            this.producto = producto;
            this.comiqueria = comiqueria;
        }
        private void ActualizarPrecio()
        {
            int cantidadSeleccionada = Convert.ToInt32(this.numericUpDownCantidad.Value);
            double nuevoPrecioFinal = Venta.CalcularPrecioFinal(this.producto.Precio, cantidadSeleccionada);
            this.lblPrecioFinal.Text = String.Format("Precio Final: ${0:0.00}", nuevoPrecioFinal);
        }

        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            this.ActualizarPrecio();
            //lblPrecioFinal.Text=(Venta.CalcularPrecioFinal(this.precio,(int)numericUpDownCantidad.Value)).ToString();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if((int)numericUpDownCantidad.Value > stock)
            {
                MessageBox.Show("Ha excedido el stock disponible, baje las pretensiones","Stock excedido",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Gracias por su compra", "Compra exitosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //this.comiqueria.Vender(this.producto, Convert.ToInt32(numericUpDownCantidad.Value));
                this.DialogResult = DialogResult.OK;
                this.Close();
                //Venta nuevaVenta = new Venta();
                //(this.producto, (int)numericUpDownCantidad.Value);
            }

        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            this.lblDescripcion.Text = this.descripcion;
            this.ActualizarPrecio();
            //lblPrecioFinal.Text = (Venta.CalcularPrecioFinal(this.precio, (int)numericUpDownCantidad.Value)).ToString();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

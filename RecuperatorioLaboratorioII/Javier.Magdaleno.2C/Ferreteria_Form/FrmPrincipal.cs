using Ferreteria_Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria_Form
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// sobrecarga del Constructor por defecto sus parametros determinan que 
        /// caracteristicas va a tener el formulario que se istancie (usuario o admin)
        /// y le pasa por parametro ademas el titulo.
        /// </summary>
        /// <param name="tipoUsuario"></param>
        /// <param name="tituloFrm"></param>
        public FrmPrincipal(string tipoUsuario,string tituloFrm):this()
        {
            if (tipoUsuario == "usuario")
            {
                this.BackColor = Color.OrangeRed;
                this.groupBoxCompras.Text = tipoUsuario;
                this.groupBoxInventario.Visible = false;
                this.groupBoxCompras.Visible = true;
            }
            else
            {
                this.BackColor = Color.BlueViolet;
                this.groupBoxInventario.Text = tipoUsuario;
                this.groupBoxInventario.Visible = true;
                this.groupBoxCompras.Visible = false;
                this.groupBoxCompras.Location = new Point(6, 213);
                this.groupBoxInventario.Location = new Point(6, 19);
            }
            this.Text = tituloFrm;
        }
        /// <summary>
        /// El metodo carga en un string el listado de los productos que estan
        /// en el inventario con stock positivo y rellena con estos datos al richTextBox
        /// que contiene este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            string listaProducto = Tienda.MostrarProductos(Tienda.ListaProductosInventario, "Lista de Productos en Stock");
            this.richTextBoxMostrarProductos.Text = listaProducto;
        }
        /// <summary>
        /// Este metodo intancia un nuevo formulario Carrito el cual se encargara
        /// de manejar el alta y baja de los pedidos antes, durante y despues de realizar
        /// una compra o desestimarla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCarrito_Click(object sender, EventArgs e)
        {
            FrmCarrito frmCarrito = new FrmCarrito("Carrito");
            frmCarrito.ShowDialog();
        }
        /// <summary>
        /// Este metoodo instanciara y abrira un nuevo formulario donde se
        /// cargaran algunos campos para realizar una busqueda dentro de la lista de 
        /// productos que contenga el inventario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            FrmCarrito frmBuscar = new FrmCarrito("Busqueda");
            frmBuscar.ShowDialog();
        }
        /// <summary>
        /// Limpiara los richTextBox que contien el formulario para luego llenarlos
        /// con la informacion total que contenga el inventario, tanto sus pedidos
        /// como los productos que tienen stock positivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.richTextBoxMostrarProductos.Text = "";
            this.richTextBoxMostrarProductos.Text = "\nTodos los Pedidos\n";
            
            this.richTextBoxMostrarProductos.Text +=
                Tienda.MostrarInventario();

            this.richTextBoxMostrarProductos.Text += 
                Tienda.MostrarProductos(Tienda.ListaProductosInventario,"Todos los productos en stock");
        }
        /// <summary>
        /// el evento click del botton btnAltaProducto desencadenara la instancia
        /// de un nuevo formulario el cual contendra los campos que seran cargados
        /// para dar el alta a un nuevo producto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            FrmAltaDeProductos frmAltaDeProductos = new FrmAltaDeProductos("Alta de Productos");
            frmAltaDeProductos.ShowDialog();
        }
        /// <summary>
        /// Este evento controlara el cierre del formulario preguntara si se esta
        /// seguro de cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Esta seguro de Cerrar el Formulario?", "Cerrando...",
                                    MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                //Tienda.ActualizaStock(Tienda.Pedido);
                this.Dispose(true);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}

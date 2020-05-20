using Ferreteria_Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria_Form
{
    public partial class FrmCarrito : Form
    {
        public FrmCarrito()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sobrecarga del constructor por defecto para poder instanciar dos
        /// formularios distintos segun la cantidad de parametros. 
        /// frmCarrito o frmBusqueda
        /// </summary>
        /// <param name="tituloFrm"></param>
        public FrmCarrito(string tituloFrm):this()
        {
            if (tituloFrm=="Busqueda")
            {
                GroupBox groupBoxBuscar;
                Button btnBuscar;

                btnBuscar = new Button();
                btnBuscar.Size = new Size(117, 38);
                btnBuscar.Location = new Point(119, 29);
                btnBuscar.Click += new EventHandler(btnBuscar_Click);
                groupBoxBuscar = new GroupBox();
                groupBoxBuscar.Location = new Point(23, 210);
                groupBoxBuscar.Size = new Size(367, 100);
                groupBoxBuscar.Controls.Add(btnBuscar);
                
                this.Controls.Add(groupBoxBuscar);
                this.Controls.Add(groupBoxBuscar);
                
                this.groupBoxCompra.Enabled = false;
                this.groupBoxCompra.Visible = false;
                groupBoxBuscar.BringToFront();
                groupBoxBuscar.Text = "Buscar";
                btnBuscar.Text = "Busqueda";

                this.groupBoxCarrito.Text = tituloFrm;
                //this.groupBoxListarPedidos.Visible = false;
                this.groupBoxListarPedidos.Text = "Producto y Manual";
                this.ListarProductosInventario();

                this.comboBoxTipoAmbito.DataSource = Enum.GetValues(typeof(TipoAmbito));
                this.comboBoxTipoUsuario.DataSource = Enum.GetValues(typeof(TipoUsuario));
            }
            else
            {
                this.BackColor = Color.Pink;
                this.groupBoxCompra.Visible = true;
                //this.groupBoxBuscar.Visible = false;
                this.groupBoxCarrito.Text = tituloFrm;
                this.groupBoxListarPedidos.Visible = true;
                this.Width = 1107;
                
                if (VerificaCarritoNoVacio(Tienda.Pedido))
                    this.btnComprar.Enabled = true;
                else
                    this.btnComprar.Enabled = false;

                this.ListarProductosInventario();
                
                this.comboBoxTipoAmbito.DataSource = Enum.GetValues(typeof(TipoAmbito));
                this.comboBoxTipoUsuario.DataSource = Enum.GetValues(typeof(TipoUsuario));
            }
        }
        //private void FrmCarrito_Load(object sender, EventArgs e)
        //{
        //}
        /// <summary>
        /// Evento click del btnBuscar asigna a un producto los valores que le
        /// retorne la busqueda, si no encuentra coincidencia el nuevo producto sera null
        /// de lo contrario sera igual al producto encontrado y mostrara sus datos en un 
        /// rickTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnBuscar_Click(object sender, EventArgs e)
        {
            this.richTextBoxPedidos.Text = "";
            Producto productoBuscado;
            productoBuscado = Tienda.BuscarProducto(Tienda.Inventario.ListaProductos,
                this.textBoxDescripcion.Text,
                (TipoAmbito)this.comboBoxTipoAmbito.SelectedItem,
                (TipoUsuario)this.comboBoxTipoUsuario.SelectedItem);
            if (!(productoBuscado is null))
            {
                this.richTextBoxPedidos.Text = productoBuscado.ToString();
            }
            else
            {
                MessageBox.Show("Producto no Encontrado","Error!", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }
        /// <summary>
        /// El evento click btnAgregar buscara primero el producto ingresado si no lo encuentra
        /// mostrara un mensaje de "producto no encontrado". Por el contrario si lo encuentra
        /// lo agregara al carrito de compra y actualizara la informacion contenida en los 
        /// richTextBox tanto de productos como de pedidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto nuevoProducto;

            nuevoProducto=Tienda.BuscarProducto(Tienda.Inventario.ListaProductos,
                                textBoxDescripcion.Text,
                                (TipoAmbito)comboBoxTipoAmbito.SelectedItem, 
                                (TipoUsuario)comboBoxTipoUsuario.SelectedItem);

            if (!(nuevoProducto is null))
            {
                if (!(textBoxDescripcion.Text == ""))
                {
                    if (Tienda.AgregarAlCarrito(nuevoProducto))
                    {
                        this.richTextBoxPedidos.Text = Tienda.MostrarCarrito();
                        this.richTextBoxProductos.Text = Tienda.MostrarProductos(
                            Tienda.ListaProductosInventario,"Listado Productos c/ Stock");
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el Producto para Agregar", "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                } 
            }
            else
            {
                MessageBox.Show("No se encontro el Producto", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (VerificaCarritoNoVacio(Tienda.Pedido))
                this.btnComprar.Enabled = true;
            else
                this.btnComprar.Enabled = false;
            this.textBoxDescripcion.Text = "";
        }
        /// <summary>
        /// el evento click btnQuitar buscara el producto requerido dentro de la lista 
        /// de pedidos (carrito) y si no lo encuentra ofrecera un mensaje de no encontrado
        /// Si lo encuentra lo quitara y actualizara tanto los rickTextBox de pedidos como
        /// de Productos actualizando su stock o devolviendolo a lista si acaso hubiese sido
        /// quitado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Producto nuevoProducto;

            nuevoProducto = Tienda.BuscarProducto(Tienda.Pedido.ListaDePedidos,
                                textBoxDescripcion.Text,
                                (TipoAmbito)comboBoxTipoAmbito.SelectedItem,
                                (TipoUsuario)comboBoxTipoUsuario.SelectedItem);

            if (!(nuevoProducto is null))
            {
                if (!(textBoxDescripcion.Text == ""))
                {
                    if (Tienda.QuitarDelCarrito(nuevoProducto))
                    {
                        this.richTextBoxPedidos.Text = Tienda.MostrarCarrito();
                        this.richTextBoxProductos.Text = Tienda.MostrarProductos(
                            Tienda.ListaProductosInventario, "Listado Productos c/ Stock");
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el Producto a Borrar", "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontro el Producto", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (VerificaCarritoNoVacio(Tienda.Pedido))
                this.btnComprar.Enabled = true;
            else
                this.btnComprar.Enabled = false;
            this.textBoxDescripcion.Text = "";
        }
        /// <summary>
        /// El evento click btnComprar manejara que todos los productos en el 
        /// carrito pasen al inventario si esto ocurre el mensaje sera exitoso 
        /// sino marcara que no ha sido posible. actualizara los datos de los 
        /// richTextBox del formulario con nuevos datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (Tienda.Comprar())
            {
                MessageBox.Show("La Compra se realizo con Exito!", "Compra Realizada!",
                    MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Carrito Vacio", "Error!",
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            this.richTextBoxPedidos.Text = "";
            textBoxDescripcion.Text = "";
            this.ListarProductosInventario();
            if (VerificaCarritoNoVacio(Tienda.Pedido))
                this.btnComprar.Enabled = true;
            else
                this.btnComprar.Enabled = false;
        }
        /// <summary>
        /// El metodo VerificaCarritoNoVacio responde a la necesidad de bloquear o no
        /// el boton Compra dependiendo si el carrito tiene o no productos cargados
        /// </summary>
        /// <param name="carrito"></param>
        /// <returns></returns>
        public bool VerificaCarritoNoVacio(Pedido carrito)
        {
            int i = 0;
            foreach (Producto item in carrito.ListaDePedidos)
            {
                i++;
            }
            if (i > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// el Evento ListarProductosInventario llena los richTextBox con los datos 
        /// del inventario tanto lista de productos en stock como los pedidos que 
        /// contenga
        /// </summary>
        public void ListarProductosInventario()
        {
            this.richTextBoxPedidos.Text = "";
            this.richTextBoxProductos.Text =
                Tienda.MostrarProductos(Tienda.ListaProductosInventario, "Lista de Productos");
                Tienda.MostrarCarrito();
        }
        /// <summary>
        /// controla el Evento de cierre del formulario. Si el carrito tiene productos
        /// cargados al momento del cierre este evento devolvera los productos al stock
        /// antes del cierre y actualizara datos del inventario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCarrito_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Esta seguro de Cerrar el Formulario?", "Cerrando...",
                MessageBoxButtons.YesNo);
            if (res==DialogResult.Yes)
            {
                Tienda.ActualizaStock(Tienda.Pedido);

                this.Dispose(true);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}

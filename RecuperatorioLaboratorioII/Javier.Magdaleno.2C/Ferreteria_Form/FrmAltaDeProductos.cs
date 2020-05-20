using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria_Biblioteca;

namespace Ferreteria_Form
{
    public partial class FrmAltaDeProductos : Form
    {
        private int opcionChequeado;
        public FrmAltaDeProductos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sobrecarga del Constructor por defecto que inicializa datos dentro del 
        /// nuevo Formulario, encargado de inicializar los comboBox con los Enumerados
        /// necesarios, el titulo del form esta contenido en el parametro de entrada
        /// </summary>
        /// <param name="tituloForm"></param>
        public FrmAltaDeProductos(string tituloForm):this()
        {
            this.comboBoxTipoAmbito.DataSource = Enum.GetValues(typeof(TipoAmbito));
            this.comboBoxTipoUsuario.DataSource = Enum.GetValues(typeof(TipoUsuario));
            this.comboBoxTipoRosca.DataSource = Enum.GetValues(typeof(Buloneria.TipoRosca));
            this.comboBoxTipoManual.DataSource = Enum.GetValues(typeof(HerramientasElectricas.TipoManual));
            this.Text = tituloForm;
            //this.BackColor = Color.Violet;
            this.opcionChequeado = 0;
            this.CheckedRadioButton(opcionChequeado);
        }
        /// <summary>
        /// El evento CheckedRadioButton servira para poder visibilizar o no parte
        /// de los datos a cargar, segun el Tipo de Producto (segun su Clase derivada)
        /// </summary>
        /// <param name="opcion"></param>
        public void CheckedRadioButton(int opcion)
        {
            switch (opcion)
            {
                case 0:
                    this.groupBoxBuloneria.Enabled = true;
                    this.groupBoxHerramientas.Enabled = false;
                    this.groupBoxMateriales.Enabled = false;
                    break;
                case 1:
                    this.groupBoxBuloneria.Enabled = false;
                    this.groupBoxHerramientas.Enabled = true;
                    this.groupBoxMateriales.Enabled = false;

                    break;
                case 2:
                    this.groupBoxBuloneria.Enabled = false;
                    this.groupBoxHerramientas.Enabled = false;
                    this.groupBoxMateriales.Enabled = true;

                    break;
                default:
                    this.groupBoxBuloneria.Enabled = true;
                    this.groupBoxHerramientas.Enabled = false;
                    this.groupBoxMateriales.Enabled = false;
                    break;
            }
        }
        /// <summary>
        /// los distintos eventos CheckedChaged de los RadioButtons serviran para
        /// setear la opcion y se la pasara al metodo CheckedRadioButton que sera 
        /// encargado de habilitar / Deshabilitar distintos campos de los productos
        /// Cada uno de ellos le dara un valor distinto al atributo opcionChequeado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonBuloneria_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBuloneria.Checked)
            {
                this.opcionChequeado = 0;
                this.CheckedRadioButton(opcionChequeado);
            }
        }
        private void radioButtonHerramientas_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHerramientas.Checked)
            {
                this.opcionChequeado = 1;
                this.CheckedRadioButton(opcionChequeado);
            }
        }
        private void radioButtonMateriales_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMateriales.Checked)
            {
                this.opcionChequeado = 2;
                this.CheckedRadioButton(opcionChequeado);
            }
        }
        /// <summary>
        /// El evento click btnGrabar hara un switch de acuerdo al valor del 
        /// atributo opcionChequeado que varia segun se presionen los radioButton
        /// y segun este valor llamara al constructor adecuado para crear un nuevo
        /// objeto de dicha clase. si el proceso es satisfactorio y el el campo stock es
        /// mayor que cero, el producto sera incorporado a la lista de productos del 
        /// inventario y a la lista de productos de la tienda.si por caso el stock es 
        /// igual o menor que cero solo sera incorporado a la lista de productos de la
        /// tienda. En el caso de ser Null ofrecera un mensaje en tal sentido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Producto p;

            p = Tienda.BuscarProducto(Tienda.ListaProductosInventario,
                textBoxDescripcion.Text, (TipoAmbito)comboBoxTipoAmbito.SelectedItem,
                (TipoUsuario)comboBoxTipoUsuario.SelectedItem);
 
            if(!(p is null))
            {
                MessageBox.Show("No se pudo Dar de Alta el Producto" +
                    "\nEl mismo ya se encuentra en la lista", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                switch (this.opcionChequeado)
                {
                    case 0:
                        p = new Buloneria(int.Parse(textBoxCodigo.Text), textBoxDescripcion.Text,
                            double.Parse(textBoxPrecio.Text), int.Parse(textBoxStock.Text),
                            (TipoAmbito)comboBoxTipoAmbito.SelectedItem,
                            (TipoUsuario)comboBoxTipoUsuario.SelectedItem,
                            float.Parse(textBoxLargo.Text), float.Parse(textBoxDiametro.Text),
                            (Buloneria.TipoRosca)comboBoxTipoRosca.SelectedItem);
                        break;
                    case 1:
                        p = new HerramientasElectricas(int.Parse(textBoxCodigo.Text), textBoxDescripcion.Text,
                            double.Parse(textBoxPrecio.Text), int.Parse(textBoxStock.Text),
                            (TipoAmbito)comboBoxTipoAmbito.SelectedItem,
                            (TipoUsuario)comboBoxTipoUsuario.SelectedItem, int.Parse(textBoxPeso.Text),
                            (HerramientasElectricas.TipoManual)comboBoxTipoManual.SelectedItem);
                        break;
                    case 2:
                        p = new MaterialesElectricos(int.Parse(textBoxCodigo.Text), textBoxDescripcion.Text,
                            double.Parse(textBoxPrecio.Text), int.Parse(textBoxStock.Text),
                            (TipoAmbito)comboBoxTipoAmbito.SelectedItem,
                            (TipoUsuario)comboBoxTipoUsuario.SelectedItem, textBoxOrigen.Text,
                            checkBoxEsArtefacto.Checked, int.Parse(textBoxVoltaje.Text));
                        break;
                    default:
                        p = null;
                        break;
                }
                if (!(p is null))
                {
                    if (p.Stock > 0)
                    {
                        Tienda.AgregarProducto(Tienda.ListaProductosInventario, p);
                        Tienda.AgregarProducto(Tienda.ListaProductosTienda, p);
                    }
                    else
                    {
                        Tienda.AgregarProducto(Tienda.ListaProductosTienda, p);
                    }
                    MessageBox.Show("Alta del producto Exitosa", "Agregado!",
                        MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("No se pudo Dar de Alta el producto", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } 
            }
            this.LimpiarControles();
        }
        /// <summary>
        /// El metodo LimpiarControles se utiliza para limpiar el contendido de 
        /// los controles TextBox para estar listo ante una nueva carga de producto.
        /// </summary>
        public void LimpiarControles()
        {
            this.textBoxCodigo.Text = "";
            this.textBoxDescripcion.Text = "";
            this.textBoxPrecio.Text = "";
            this.textBoxStock.Text = "";
            this.textBoxLargo.Text = "";
            this.textBoxDiametro.Text = "";
            this.textBoxPeso.Text = "";
            this.textBoxOrigen.Text = "";
            this.textBoxVoltaje.Text = "";
            this.checkBoxEsArtefacto.Checked = false;
        }
        /// <summary>
        /// El evento click del btnSalir dispara una llamada al evento
        /// FormClosing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose(true);
        }
        /// <summary>
        /// El evento FrmClosing contrala el cierre del formulario, dando una
        /// chance de proseguir con la tarea o no.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAltaDeProductos_FormClosing(object sender, FormClosingEventArgs e)
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

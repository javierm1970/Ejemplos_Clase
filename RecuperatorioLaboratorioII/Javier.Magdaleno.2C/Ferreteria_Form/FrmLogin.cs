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
    /// <summary>
    /// Atributos del Formulario del Login / loginUsuario loginAdmin y sus contraseñas
    /// </summary>
    public partial class FrmLogin : Form
    {
        private string loginUsuario;
        private string loginAdmin;
        private string contraUsuario;
        private string contraAdmin;
        /// <summary>
        /// Constructor que inicializa los usuarios y contraseñas del sistema
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
            this.loginUsuario = "usuario";
            this.contraUsuario = "123456";
            this.loginAdmin = "admin";
            this.contraAdmin = "1234";
        }
        /// <summary>
        /// Los Metodos RadioButtonUsuario_CheckedChanged() y RadioButtonAdmin_CheckedChanged()
        /// son la forma de identificar al usuario y pasarles el hardcodeo 
        /// determinan ademas que formulario se va a abrir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonUsuario_CheckedChanged(object sender, EventArgs e)
        {
            textBoxUsuario.Text = this.loginUsuario;
            textBoxContrasena.Text = this.contraUsuario;
        }

        private void radioButtonAdmin_CheckedChanged(object sender, EventArgs e)
        {
            textBoxUsuario.Text = this.loginAdmin;
            textBoxContrasena.Text = this.contraAdmin;
        }
        /// <summary>
        /// El metodo btnLogin_Click controla el usuario y contraseña y instancian
        /// el formulario que se va a abrir en cada caso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tituloFrm;
            bool loginOk = true;
            if (!(radioButtonAdmin.Checked==false && radioButtonUsuario.Checked==false))
            {
                if (radioButtonUsuario.Checked)
                {
                    tituloFrm = string.Format("Bienvenido {0}", textBoxUsuario.Text);
                    if (!(textBoxUsuario.Text == "usuario" && textBoxContrasena.Text == "123456"))
                    {
                        MessageBox.Show("Usuario o Contraseña erronea", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        loginOk = false;
                    }
                }
                else
                {
                    tituloFrm = string.Format("Modo Vendedor");
                    if (!(textBoxUsuario.Text == "admin" && textBoxContrasena.Text == "1234"))
                    {
                        MessageBox.Show("Usuario o Contraseña erronea", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        loginOk = false;
                    }
                }
                if (loginOk)
                {
                    FrmPrincipal frmPrincipal = new FrmPrincipal(textBoxUsuario.Text,tituloFrm);
                    frmPrincipal.ShowDialog();  
                }
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña erronea", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         }
    }
}

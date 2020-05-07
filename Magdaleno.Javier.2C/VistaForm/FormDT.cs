using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Equipos;
namespace VistaForm
{
    public partial class FormDT : Form
    {
        private DirectorTecnico dt;

        public FormDT()
        {
            InitializeComponent();
            
        }
        private void FormDT_Load(object sender, EventArgs e)
        {
            this.numUDDni.Value = 0;
            this.numUDEdad.Value = 0;
            this.numUDExperiencia.Value = 0;
        }
        public void ValidarDT(DirectorTecnico dt)
        {
            if (this.dt is null)
            {
                MessageBox.Show("Aún no se ha creado el DT del Formulario");
            }
            else
            {
                string mensaje = "El DT no es Apto";
                if (dt.ValidarAptitud())
                {
                    mensaje = "El DT es Apto";
                }
                MessageBox.Show(mensaje);
            }
        }
        public void CrearDT(DirectorTecnico dt)
        {
            dt = new DirectorTecnico(textBoxNombre.Text, textBoxApellido.Text,
                (int)numUDEdad.Value, (int)numUDDni.Value, (int)numUDExperiencia.Value);
            this.dt = dt;
            MessageBox.Show("Se ha creado el DT!");
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            this.CrearDT(this.dt);
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            this.ValidarDT(this.dt);
        }
    }
}

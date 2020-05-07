using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia)
            :base(nombre, apellido, edad, dni)
        {
            this.añosExperiencia = añosExperiencia;
        }

        public int AñosExperiencia
        {
            get 
            {
                return this.añosExperiencia; 
            }
            set 
            { 
                this.añosExperiencia = value; 
            }
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("\nExperiencia: {0}", this.AñosExperiencia);

            return sb.ToString();
        }

        public override bool ValidarAptitud() 
        {
            if(this.AñosExperiencia>2 && this.Edad < 65)
            {
                return true;
            }
            return false;
        }




    }
}

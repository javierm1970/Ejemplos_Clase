using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos
{
    public enum Posicion
    {
        Arquero, Defensor, Central, Delantero
    }
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        public int Edad
        {
            get
            {
                return this.edad;
            }
        }
        public int Dni
        {
            get
            {
                return dni;
            }
        }
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("\nNombre: {0}", this.Nombre);
            sb.AppendFormat("\nApellido: {0}", this.Apellido);
            sb.AppendFormat("\nDNI: {0}", this.Dni);
            sb.AppendFormat("\nEdad: {0}", this.Edad);

            return sb.ToString();
        }
        public abstract bool ValidarAptitud();


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion)
            :base(nombre, apellido,edad,dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }
        public float Peso
        {
            get
            {
                return this.peso;
            }
        }
        public float Altura
        {
            get
            {
                return this.altura;
            }
        }
        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("\nPeso: {0:##0.00}", this.Peso);
            sb.AppendFormat("\nAltura: {0:##0.00}", this.Altura);
            sb.AppendFormat("\nPosicion: ", this.Posicion);

            return sb.ToString();
        }
        public override bool ValidarAptitud()
        {
            if (this.ValidarEstadoFisico() && this.Edad <= 40)
            {
                return true;
            }
            return false;
        }
        public bool ValidarEstadoFisico()
        {
            float IMC = this.peso / (this.Altura*this.Altura);
            if (IMC>=18.5 && IMC <= 25)
            {
                return true;
            }
            return false;
        }


    }
}

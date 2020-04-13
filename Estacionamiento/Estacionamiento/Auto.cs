using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento1
{
    public class Auto
    {
        private string patente;
        private string marca;
        private int cantidadPuerta;
        private double dni;

        public Auto(string pat, string mar, int cant,double doc) : this(pat,doc) 
        {
            this.marca = mar;
            this.cantidadPuerta = cant;
        }
        public Auto(string pat, double doc) :this()
        {
            this.patente = pat;
            this.dni = doc;
        }
        private Auto()
        {
            this.marca = "dato no ingresado";
            this.cantidadPuerta = -1;
        }
        public string GetInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Patente: {this.patente}");
            sb.AppendFormat("Marca: {0} \n", this.marca);
            if (this.cantidadPuerta == -1)
                sb.AppendLine("Cantidad Puertas: "+ "datos no ingresados");
            else
                sb.AppendLine("Cantidad Puertas: " + this.cantidadPuerta);

            sb.AppendLine("Dni: "+this.dni);

            return sb.ToString();
        }
        public void Setinformacion(int cantPuertas)
        {
            this.cantidadPuerta = cantPuertas;
        }
        public void Setinformacion(string marca)
        {
            this.marca=marca;
        }
        public void Setinformacion(string marca,int cantPuertas)
        {
            this.Setinformacion(marca);
            this.Setinformacion(cantPuertas);
        }
        public static bool operator ==(Auto a,Auto b)
        {
            //bool boolEsIgual=false;
            //if (a.patente == b.patente)
            //{
            //    boolEsIgual = true;
            //}
            //return boolEsIgual;
            return (a.patente == b.patente);
        }
        public static bool operator !=(Auto a, Auto b)
        {
            //bool boolEsIgual = true;
            //if (a.patente == b.patente)
            //{
            //    boolEsIgual = false;
            //}
            //return boolEsIgual;
            return !(a == b);
        }
        public static explicit operator string(Auto autito)
        {
            return autito.GetInformacion();
        }

    }
}

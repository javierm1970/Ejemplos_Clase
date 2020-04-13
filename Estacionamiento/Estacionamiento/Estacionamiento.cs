using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento1
{
    public class Estacionamiento
    {
        private string nombreEstacionamiento;
        private Auto[] arrayDeAutos;
        private double precioPorAuto;
        private static Random numeroAleatorio;

        public Estacionamiento(string nomEst, int capacidadEst) : this(capacidadEst)
        {
            this.nombreEstacionamiento = nomEst;
        }
        private Estacionamiento(int capacidadEst)
        {
            this.arrayDeAutos = new Auto[capacidadEst];
            this.precioPorAuto = Estacionamiento.PrecioEstacionamiento();
        }
        static Estacionamiento()
        {
            numeroAleatorio = new Random();
        }
        public static int PrecioEstacionamiento()
        {
            return numeroAleatorio.Next(100, 300);
        }

        public string GetInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre Estacionamiento: {this.nombreEstacionamiento}");
            sb.AppendFormat("Precio Estacionamiento: {0} \n", this.precioPorAuto);

            for (int i = 0; i < this.arrayDeAutos.Length; i++)
            {
                if (!(this.arrayDeAutos[i] is null))
                {
                    sb.Append("----------------------------------\n");
                    sb.Append(this.arrayDeAutos[i].GetInformacion());
                }
            }
            return sb.ToString();
        }
        public static bool operator ==(Estacionamiento estacionamiento, Auto auto)
        {
            return estacionamiento.arrayDeAutos.Contains(auto);
            //bool esta = false;
            //foreach (Auto auto1 in estacionamiento.arrayDeAutos)
            //{
            //    if (!(auto1 is null))
            //    {
            //        if (auto1 == auto)
            //        {
            //            esta = true;
            //        } 
            //    }
            //}

            //for (int i=0; i<estacionamiento.arrayDeAutos.Length; i++)
            //{
            //    if (!(estacionamiento.arrayDeAutos[0] is null))
            //    {
            //        if (estacionamiento.arrayDeAutos[0] == auto)
            //        {
            //            esta = true;
            //        } 
            //    }
            //}

            //return esta;
        }

        public static bool operator !=(Estacionamiento estacionamiento, Auto auto)
        {
            return !(estacionamiento == auto);
        }
        public static bool operator + (Estacionamiento estacionamiento, Auto auto)
        {
            bool agrego = false;
            for (int i = 0; i < estacionamiento.arrayDeAutos.Length; i++)
            {
                if (estacionamiento.arrayDeAutos[i] is null)
                {
                    estacionamiento.arrayDeAutos[i] = auto;
                    agrego = true;
                    break;
                }
            }
            return agrego;
        }

        public static implicit operator Estacionamiento (int capacidad)
        {
            return new Estacionamiento("Sin Identificar",capacidad);
        }





    }





}

using CentralitaHerencia;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }
        protected Franja franjaHoraria;

        public Provincial(Franja miFranja, Llamada llamada)
            :this(llamada.NroOrigen,miFranja,llamada.Duracion,llamada.NroDestino)
        {
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        private float CalcularCosto()
        {
            float retorno;
            
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno = this.duracion * 0.99f;
                    break;
                case Franja.Franja_2:
                    retorno = this.duracion * 1.25f;
                    break;
                case Franja.Franja_3:
                    retorno = this.duracion * 0.66f;
                    break;
                default:
                    retorno = 0;
                    break;
            }
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}   Costo Llamada: {1}   Franja: {2}"
                , base.Mostrar(), this.CostoLlamada, this.franjaHoraria);

            return sb.ToString();
        }





    }
}

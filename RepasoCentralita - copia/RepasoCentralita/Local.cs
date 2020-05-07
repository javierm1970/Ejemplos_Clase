using CentralitaHerencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo)
            :this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {
        }
        public Local(string origen, float duracion, string destino, float costo)
            :base(duracion, destino, origen)
        {
            this.costo = costo;
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
            return  this.costo * this.duracion;
        }
        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendFormat("{0}   Costo Llamada: {1}", base.Mostrar(), this.costo);
            
            return sb.ToString();
        }
    }
}

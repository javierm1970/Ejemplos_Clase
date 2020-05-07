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
        public override float CostoLlamada
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
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendFormat("\n{0}   Costo Llamada: {1}", base.Mostrar(), this.costo);
            
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj is Local)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        
    }
}

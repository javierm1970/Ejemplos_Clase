using CentralitaHerencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float resultado = 0;

            foreach (Llamada item in this.listaDeLlamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (item is Local)
                        {
                            resultado += ((Local)item).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (item is Provincial)
                        {
                            resultado += ((Provincial)item).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if (item is Local)
                        {
                            resultado += ((Local)item).CostoLlamada;
                        }
                        if (item is Provincial)
                        {
                            resultado += ((Provincial)item).CostoLlamada;
                        }
                        break;
                } 
            }
            return resultado;
        }
        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("\nRazon Social: {0}  /  Ganancia Total: {1}"
                , this.razonSocial, this.CalcularGanancia(Llamada.TipoLlamada.Todas));

            if (!(this.listaDeLlamadas is null))
            {
                foreach (Llamada item in this.listaDeLlamadas)
                {
                    if (item is Local)
                    {
                        sb.AppendFormat(((Local)item).ToString());
                    }
                    else if (item is Provincial)
                    {
                        sb.AppendFormat(((Provincial)item).ToString());
                    }
                }
            }
            return sb.ToString();
        }
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            if (!(c is null || llamada is null))
            {
                foreach (Llamada item in c.listaDeLlamadas)
                {
                    if (item == llamada)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return (!(c == llamada));
        }
        public static bool operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (!(c == nuevaLlamada))
            {
                c.AgregarLlamada(nuevaLlamada);
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

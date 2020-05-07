using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Equipos
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(string nombre):this()
        {
            this.nombre = nombre;
        }
        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud())
                {
                    this.directorTecnico = value; 
                }
            }
        }
        public static bool ValidarEquipo(Equipo e)
        {
            int cantArquero = 0;
            int canDefensor = 0;
            int canCentral = 0;
            int canDelantero = 0;

            foreach (Jugador item in e.jugadores)
            {
                switch (item.Posicion)
                {
                    case Posicion.Arquero:
                        cantArquero++;
                        break;
                    case Posicion.Defensor:
                        canDefensor++;
                        break;
                    case Posicion.Central:
                        canCentral++;
                        break;
                    case Posicion.Delantero:
                        canDelantero++;
                        break;
                }
            }
            int totalJuga = cantArquero + canCentral + canDefensor + canDelantero;
            if (cantArquero==1 && totalJuga == Equipo.cantidadMaximaJugadores && !(e.directorTecnico is null))
            {
                return true;
            }
            return false;
        }

        public static explicit operator string (Equipo e)
        {
            
            StringBuilder sb = new StringBuilder();
            if (e.directorTecnico is null)
            {
                sb.AppendFormat("Equipo: {0}   /   Director tecnico: {1}", e.nombre, "Sin DT Asignado");
            }
            else
            {
                sb.AppendFormat("Equipo: {0}   /   Director tecnico: {1}", e.nombre,e.directorTecnico);
            }
            if (!(e is null))
            {
                foreach (Jugador item in e.jugadores)
                {
                    sb.AppendLine(item.Mostrar());
                }
            }
            else
            {
                sb.AppendLine("Equipo sin Jugadores por el momento.");
            }
            return sb.ToString();
        }

        public static bool operator == (Equipo e, Jugador j)
        {
            if (!(e is null && j is null))

            {
                foreach (Jugador item in e.jugadores)
                {
                    if (item == j)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator != (Equipo e, Jugador j)
        {
            return (!(e == j));
        }
        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e!=j && Equipo.cantidadMaximaJugadores > e.jugadores.Count && j.ValidarAptitud())
            {
                e.jugadores.Add(j);
            }
            return e;
        }
    }
}

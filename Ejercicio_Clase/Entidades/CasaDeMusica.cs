using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CasaDeMusica
    {
        private int espacioEnDeposito;
        private List<InstrumentoMusical> inventarioInstrumentos;
        private ECasaMusica tipoCasaMusica;
        private string nombreCasaMusica;
        private string direccion;

        public CasaDeMusica()
        {
            inventarioInstrumentos = new List<InstrumentoMusical>();
        }
        public CasaDeMusica(int espacioEnDeposito,ECasaMusica tipo, string nombreCasaMusica, string direccion):this()
        {
            this.espacioEnDeposito = espacioEnDeposito;
            this.tipoCasaMusica = tipo;
            this.nombreCasaMusica = nombreCasaMusica;
            this.direccion = direccion;

        }


    }
}

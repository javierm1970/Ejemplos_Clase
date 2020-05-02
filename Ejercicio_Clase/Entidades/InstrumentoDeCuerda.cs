using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETipoCuerda
    {
        GuitarraElectrica,
        GuitarraAcustica,
        Bajo,
        Violin,
        Piano
    }

    public class InstrumentoDeCuerda : InstrumentoMusical
    {
        ETipoCuerda tipoInstrumento;

        public InstrumentoDeCuerda(int precio, string descNomb, string marca, int codigo)
            :base(precio,descNomb,marca,codigo)
        {

        }

    }
}

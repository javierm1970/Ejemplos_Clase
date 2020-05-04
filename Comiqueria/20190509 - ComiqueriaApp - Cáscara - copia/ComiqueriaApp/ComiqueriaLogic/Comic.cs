using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        public enum TipoComic
        {
            Occidental, Oriental
        }
        
        private string autor;
        private TipoComic tipoComic;

        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipocomic)
            :base(descripcion, stock, precio)
        {
            this.autor = autor;
            this.tipoComic = tipocomic;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.ToString());
            sb.AppendFormat("Autor: {0}", this.autor);
            sb.AppendFormat("Tipo Comic: {0}", this.tipoComic);

            return sb.ToString();
        }


    }
}

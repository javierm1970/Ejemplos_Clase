using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria_Biblioteca
{
    /// <summary>
    /// Clase derivada de la clase Producto, representa el rubro Buloneria
    /// dentro de una lista de productos de una ferreteria.
    /// </summary>
    public class Buloneria : Producto
    {
        /// <summary>
        /// Enumerado de TipoRosca, caracteristica de los productos segun
        /// si cuentan con algun tipo de rosca.
        /// </summary>

        public enum TipoRosca
        {
            PasoFino, PasoGrueso, NoTiene
        }
        /// <summary>
        /// atributos distintivos de la clase Buloneria 
        /// </summary>
        private float largoPulgada;
        private float diametroPulgada;
        private TipoRosca tipoRosca;
        private static string manual;
        /// <summary>
        /// Costructor por defecto inicializa los atributos por defecto. los pasa mediante
        /// el this() al constructor publico.
        /// </summary>
        public Buloneria()
            :this(-1,"sin Descripcion",-1,0,TipoAmbito.Hogar,TipoUsuario.Principiante,-1,-1,TipoRosca.NoTiene)
        {
        }
        /// <summary>
        ///  Constructor de instancia asigna los valores de sus atributos y transfiere
        /// los valores de los atributos comunes a la Clase base.
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        /// <param name="stock"></param>
        /// <param name="tipoAmbito"></param>
        /// <param name="tipoUsuario"></param>
        /// <param name="largo"></param>
        /// <param name="diametro"></param>
        /// <param name="tipoRosca"></param>
        public Buloneria(int codigo, string descripcion, double precio, int stock, TipoAmbito tipoAmbito, TipoUsuario tipoUsuario,
            float largo, float diametro, TipoRosca tipoRosca)
            :base(codigo, descripcion, precio, stock, tipoAmbito, tipoUsuario)
        {
            this.largoPulgada = largo;
            this.diametroPulgada = diametro;
            this.tipoRosca = tipoRosca;
            Buloneria.manual="\nLa Buloneria no cuenta con Manual.\nUticilice Gafas de proteccion y guantes adecuados";
        }
        /// <summary>
        /// Propiedad de solo lectura que devuelve el atributo privado Tipo float largoPulgada
        /// </summary>
        public float LargoPulgada
        {
            get
            {
                return this.largoPulgada;
            }
        }
        /// <summary>
        /// Propiedad de solo lectura que devuelve el atributo privado Tipo float diametroPulgada
        /// </summary>
        public float DiametroPulgada
        {
            get
            {
                return this.diametroPulgada;
            }
        }
        /// <summary>
        /// Propiedad de solo lectura que devuelve el atributo privado TipoRosca tipoRosca
        /// </summary>
        public TipoRosca TipoRoscado
        {
            get
            {
                return this.tipoRosca;
            }
        }
        /// <summary>
        /// Escritura de la Propiedad de solo lectura abstracta de la clase base
        /// realiza un calculo para determinar la tasa de ganancia de un producto
        /// y retornarlo del tipo float.
        /// </summary>
        public override float CalcularMargenDeGanancia
        {
            get
            {
                return (float) this.Precio * 10 / 100;
            }
        }
        /// <summary>
        /// Escritura del metodo abstracto de la clase base, que devuelve un
        /// string que contien un manual de instrucciones.
        /// </summary>
        /// <returns></returns> string
        public override string InstruccionesDeUso()
        {
            return Buloneria.manual;
        }
        /// <summary>
        /// Sobreescritura del metodo ToString() que devuelve un string que 
        /// contiene los datos tanto de la Clase base como los especificos 
        /// de la clase deriva.
        /// </summary>
        /// <returns></returns> string
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());

            sb.AppendFormat("\nLargo: {0} pulgadas", this.LargoPulgada);
            sb.AppendFormat("\nDiametro: {0} pulgadas", this.DiametroPulgada);
            sb.AppendFormat("\nTipo de Rosca {0}", this.TipoRoscado);
            sb.Append("\n");
            sb.Append('*', 60);
            sb.AppendLine(InstruccionesDeUso());
            sb.Append('*', 60);
            sb.Append("\n");
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria_Biblioteca
{
    /// <summary>
    /// Clase derivada de la clase Producto, representa el rubro Materiales Electricos
    /// dentro de una lista de productos de una ferreteria.
    /// </summary>
    public class MaterialesElectricos : Producto
    {
        /// <summary>
        /// atributos distintivos de la clase MaterialesElectricos 
        /// </summary>
        private string origen;
        private bool esArtefacto;
        private int voltaje;
        private static string manual;
        /// <summary>
        /// Costructor por defecto inicializa los atributos por defecto. los pasa mediante
        /// el this() al constructor publico.
        /// </summary>
        public MaterialesElectricos()
            : this(-1, "sin Descripcion", -1, 0, TipoAmbito.Hogar,TipoUsuario.Principiante,"Sin Determinar",true,0)
        {
        }
        /// <summary>
        /// Constructor de instancia asigna los valores de sus atributos y transfiere
        /// los valores de los atributos comunes a la Clase base.
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        /// <param name="stock"></param>
        /// <param name="tipoAmbito"></param>
        /// <param name="tipoUsuario"></param>
        /// <param name="origen"></param>
        /// <param name="esArtefacto"></param>
        /// <param name="voltaje"></param>
        public MaterialesElectricos(int codigo, string descripcion, double precio,
            int stock, TipoAmbito tipoAmbito, TipoUsuario tipoUsuario, string origen, bool esArtefacto,int voltaje)
            : base(codigo, descripcion, precio, stock,tipoAmbito, tipoUsuario)
        {
            this.origen = origen;
            this.esArtefacto = esArtefacto;
            this.voltaje = voltaje;
            MaterialesElectricos.manual="\nLos Artefacto Electricos no cuenta con Manual, " +
                "\nRespete las medidas de seguridad al momento de instalarlo.";
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
                return (float)this.Precio * 16 / 100;
            }
        }
        /// <summary>
        /// Propiedad de solo lectura que devuelve el atributo privado tipo string origen
        /// </summary>
        public string Origen
        {
            get
            {
                return this.origen;
            }
        }
        /// <summary>
        /// Propiedad de solo lectura que devuelve el atributo privado tipo bool esArtefacto
        /// </summary>
        public bool EsArtefacto
        {
            get
            {
                return this.esArtefacto;
            }
        }
        /// <summary>
        /// Propiedad de solo lectura que devuelve el atributo privado tipo string voltaje
        /// </summary>
        public int Voltaje
        {
            get 
            { 
                return this.voltaje;
            }
        }
        /// <summary>
        /// Escritura del metodo abstracto de la clase base, que devuelve un
        /// string que contien un manual de instrucciones.
        /// </summary>
        /// <returns></returns>
        public override string InstruccionesDeUso()
        {
            return MaterialesElectricos.manual;
        }
        /// <summary>
        /// Sobreescritura del metodo ToString() que devuelve un string que 
        /// contiene los datos tanto de la Clase base como los especificos 
        /// de la clase deriva.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());

            sb.AppendFormat("\nOrigen: {0}", this.Origen);
            sb.AppendFormat("\nEs un Artefacto ? {0}", this.esArtefacto);
            sb.AppendFormat("\nVoltaje: {0} vol", this.voltaje);

            sb.Append("\n"); 
            sb.Append('*', 60);
            sb.AppendLine(InstruccionesDeUso());
            sb.Append('*', 60);
            sb.Append("\n");

            return sb.ToString();
        }
    }
}

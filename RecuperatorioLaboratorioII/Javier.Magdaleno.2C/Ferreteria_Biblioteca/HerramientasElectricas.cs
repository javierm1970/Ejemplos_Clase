using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria_Biblioteca
{
    /// <summary>
    /// Clase derivada de la clase Producto, representa el rubro Herramientas Electricas
    /// dentro de una lista de productos de una ferreteria.
    /// </summary>
    public class HerramientasElectricas : Producto
    {
        /// <summary>
        /// Enumerado de TipoManual, caracteristica de los productos segun
        /// el tipo de manual que le corresponda.
        /// </summary>
        public enum TipoManual
        {
            ManualMoladora, ManualTaladro, NoTieneManual
        }
        /// <summary>
        /// Constantes de tipo String que representan un manual para un determinado tipo
        /// de herramienta.
        /// </summary>
        public const string ManualAmoladora = "\nArtefacto a 220v, verifique cable a Tierra" +
            "\nAntes de encender Coloquese las gafas de proteccion \nColoque el Disco adecuadamente antes de cortar.";
        
        public const string ManualTaladro = "\nArtefacto a 220v, verifique cable a Tierra" +
            "\nAntes de encender Coloquese las gafas de proteccion \nColoque la Broca adecuadamente antes de Agujerear.";

        public const string SinManual = "\nEste Artefacto no cuenta con Manual, Respete las medidas de seguridad igualmente.";
        /// <summary>
        /// atributos distintivos de la clase HerramientasElectricas 
        /// </summary>
        private int peso;
        private TipoManual tipoManual;
        /// <summary>
        /// Costructor por defecto inicializa los atributos por defecto. los pasa mediante
        /// el this() al constructor publico.
        /// </summary>
        public HerramientasElectricas()
            :this(-1,"sin Descripcion",-1,0,TipoAmbito.Hogar,TipoUsuario.Principiante,0,TipoManual.NoTieneManual)
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
        /// <param name="peso"></param>
        /// <param name="tipoManual"></param>
        public HerramientasElectricas(int codigo, string descripcion, double precio,
            int stock, TipoAmbito tipoAmbito, TipoUsuario tipoUsuario, int peso, TipoManual tipoManual)
            :base(codigo,descripcion,precio,stock,tipoAmbito,tipoUsuario)
        {
            this.peso = peso;
            this.tipoManual = tipoManual;
        }
        /// <summary>
        /// Propiedad de solo lectura que devuelve el atributo privado tipo int peso
        /// </summary>
        public int Peso
        {
            get 
            {
                return this.peso;
            }
        }
        /// <summary>
        /// Propiedad de solo lectura que devuelve el atributo privado TipoManual tipoManual
        /// </summary>
        public TipoManual TipoManualHerramienta
        {
            get 
            {
                return this.tipoManual;                
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
                return (float)this.Precio * 13 / 100;
            }
        }
        /// <summary>
        /// Escritura del metodo abstracto de la clase base, que devuelve un
        /// string que contien un manual de instrucciones.
        /// </summary>
        /// <returns></returns> string
        public override string InstruccionesDeUso()
        {
            switch (this.tipoManual)
            {
                case TipoManual.NoTieneManual:
                    return SinManual;
                case TipoManual.ManualMoladora:
                    return ManualAmoladora;
                case TipoManual.ManualTaladro:
                    return ManualTaladro;
                default:
                    return SinManual;
            }
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

            sb.AppendFormat("\nPeso: {0} kgs.", this.Peso);
            sb.Append("\n");
            sb.Append('*', 60);
            sb.AppendLine(InstruccionesDeUso());
            sb.Append('*', 60);
            sb.Append("\n");
            return sb.ToString();
        }
    }
}

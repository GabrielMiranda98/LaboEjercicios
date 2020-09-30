using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Llamada
    {
        #region Atributos
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        public enum TipoLlamada { Local, Provincial, Todas };
        #endregion
        #region Propiedades
        public float Duracion { get; }
        public string NroDestino { get; }
        public string NroOrigen { get; }
        #endregion
        #region Constructores
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion
        #region Métodos
        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Duracion de la llamada {this.duracion} \n Nro Destino: {this.nroDestino} \n Nro Origen {this.nroOrigen}");
            return stringBuilder.ToString();
        }
        public static int OrdenarPorDuracion(Llamada llamada1,
            Llamada llamada2)
        {

            if (llamada1.Duracion < llamada2.Duracion)
                return -1;
            else if (llamada1.Duracion > llamada2.Duracion)
                return 1;
            else
                return 0;

        }
        #endregion
    }
}

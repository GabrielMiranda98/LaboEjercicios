using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Local : Llamada
    {
        #region Atributos
        protected float costo;
        #endregion
        #region Constructores
        public Local(Llamada llamada, float costo)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }
        #endregion
        #region Propiedades
        public float CostoLlamada { get { return this.CalcularCosto(); } }
        #endregion
        #region Metodos
        private float CalcularCosto()
        {
            return this.duracion * this.costo;
            
        }
        public new string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Costo de la llamada: {this.costo}");
            return base.Mostrar()+stringBuilder.ToString();
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Provincial : Llamada
    {
        #region Atributos
        protected Franja franjaHoraria;
        public enum Franja {Franja_1,Franja_2,Franja_3 };
        #endregion
        #region Constructores
        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(string origen,Franja miFranja,float duracion, string destino):base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }
        #endregion
        #region Propiedades
        public float CostoLlamada { get { return this.CalcularCosto(); } }
        #endregion
        #region Metodos
        private float CalcularCosto()
        {
            float ret = 0;
            switch (this.franjaHoraria) 
            {
                case Franja.Franja_1:
                    ret= this.duracion * (float)0.99;
                    break;
                case Franja.Franja_2:
                    ret= this.duracion * (float)1.25;
                    break;
                case Franja.Franja_3:
                    ret= this.duracion * (float)0.66;
                    break;
            }
            return ret;
            
        }
        public new string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"El costo de llamada es {this.CostoLlamada}");
            return base.Mostrar() + stringBuilder.ToString();
        }
        #endregion
    }
}

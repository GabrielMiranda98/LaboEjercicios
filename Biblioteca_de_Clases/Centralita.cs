using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Centralita
    {
        #region Atributos
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        #endregion
        #region Propiedades
        public List<Llamada> Llamadas
        { get { return this.listaDeLlamadas; } }
        public float GananciasPorLocal { get { return CalcularGanancia(Llamada.TipoLlamada.Local); } }
        public float GananciasPorProvincial { get { return CalcularGanancia(Llamada.TipoLlamada.Provincial); } }
        public float GananciasPorTotal { get { return CalcularGanancia(Llamada.TipoLlamada.Todas); } }

        #endregion
        #region Constructores
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        #endregion
        #region Métodos
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float total = 0;
            // Recorro la lista de llamadas.
            foreach (Llamada l in this.listaDeLlamadas)
            {
                // Según el tipo de llamada que quiero analizar, opero.
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        // Si el TipoLlamada es Local y la clase es del tipo Local...
                        if (l is Local)
                            total += ((Local)l).CostoLlamada;
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        // Si el TipoLlamada es Provincial y la clase es del tipo Provincial...
                        if (l is Provincial)
                            total += ((Provincial)l).CostoLlamada;
                        break;
                    case Llamada.TipoLlamada.Todas:
                        // Si el TipoLlamada es Todas y verifico el tipo de la llamada para castear.
                        if (l is Local)
                            total += ((Local)l).CostoLlamada;
                        else if (l is Provincial)
                            total += ((Provincial)l).CostoLlamada;
                        break;
                }
            }

            return total;
        }
        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"La razon social es: {this.razonSocial} \n La ganancia en llamadas Locales : {this.GananciasPorLocal}\nLa ganancia en llamadas Provinciales : {this.GananciasPorProvincial}\n La ganancia total es: {this.GananciasPorTotal}");
            foreach(Llamada llamada in this.listaDeLlamadas)
            {
                stringBuilder.AppendLine(llamada.Mostrar());
            }
            return stringBuilder.ToString();
        }
        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        #endregion
    }
}

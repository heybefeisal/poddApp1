using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poddApp11.BLL
{
   public class AvsnittLista
    {
        public static List<Avsnitt> avLista { get; set; }
        public AvsnittLista()
        {
            avLista = new List<Avsnitt>();
        }

        public static void laggTillAvsnitt(Avsnitt avsnitt)
        {
            avLista.Add(avsnitt);
        }

        public static List<Avsnitt> hamtaAvsnittLista()
        {
            return avLista;
        }

        public static void taBortAvs(String poddTitel)
        {
            avLista.RemoveAll(avs => avs.PoddTitel.Equals(poddTitel));
        }
    }
}

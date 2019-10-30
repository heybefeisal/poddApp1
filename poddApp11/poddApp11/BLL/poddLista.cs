using poddAppen.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poddApp11.BLL
{
    public class PoddLista
    {
        private static List<Podden> poddListor { get; set; }

        public PoddLista()
        {
            poddListor = new List<Podden>();
        }

        public static void laggTillPodd(Podden podd)
        {
            poddListor.Add(podd);
        }

        public static List<Podden> returneraLista()
        {
            return poddListor;
        }

        public static void taBortPodd(string poddTitel)
        {
            poddListor.RemoveAll(podd => podd.PoddTitel.Equals(poddTitel)); 
        }

    }
}

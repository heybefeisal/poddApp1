using poddAppen.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poddApp11.BLL
{
    public class KategoriListor
    {
        private static List<Kategori> katLista { get; set; } 

        public KategoriListor()
        {
            katLista = new List<Kategori>();
        }

        public static void laggTillKategori(Kategori kategori)
        {
            katLista.Add(kategori);
        }

        public static List<Kategori> hamtaKategoriLista()
        {
            return katLista;
        }
    }
}

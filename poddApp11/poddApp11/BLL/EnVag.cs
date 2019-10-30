using poddApp11.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poddApp11.BLL
{
    public class EnVag
    {
        public static void laggTillPodd(string url, int frekvens, string kategori)
        {
            if(ValideraKod.korrektRss(url))
            {
                lassRss.hamtaInfo(url, kategori, frekvens); 
            }
        }

        public static void skapaLista()
        {
            DL.HanteraXMLFiler.skapaPoddLista();
            DL.HanteraXMLFiler.skapaKatLista();
            DL.HanteraXMLFiler.skapaAvsnittLista();
        }

        public static void sparaLista()
        {
            HanteraXMLFiler.sparaAvsnittListor();
            HanteraXMLFiler.sparaPoddLista();
            HanteraXMLFiler.sparaKatLista();
        }
    }
}

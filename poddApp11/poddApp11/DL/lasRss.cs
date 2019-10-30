
using poddApp11.BLL;
using poddAppen.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace poddApp11.DL
{
    public class lassRss
    {
        public static async Task<int> hamtaAvRss(string url) 
        {

            using (XmlReader xReader = XmlReader.Create(url))
            {
                int i = 0;
                SyndicationFeed feed = SyndicationFeed.Load(xReader);
                foreach (SyndicationItem item in feed.Items) 
                {
                    i++;
                }
                return i;
            }
        }


        public static void hamtaInfo(string url, string kategori, int frekvens)
        {
            using (XmlReader lasare = XmlReader.Create(url))
            {
                try
                {
                    SyndicationFeed flow = SyndicationFeed.Load(lasare);
                    var titel = flow.Title.Text;
                    int raknare = 0;
                    foreach (SyndicationItem objekt in flow.Items)
                    {
                        var avsNamn = objekt.Title.Text;
                        var sammanfattning = (((TextSyndicationContent)objekt.Summary).Text);

                        Avsnitt avsnitt = new Avsnitt(titel, avsNamn, sammanfattning);
                        AvsnittLista.laggTillAvsnitt(avsnitt);
                        raknare++;
                    }
                    Podden podd = new Podden(titel, frekvens, kategori, raknare, url);
                    PoddLista.laggTillPodd(podd);
                    UFrekvens.First(titel, url, frekvens, kategori);
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Fel på RSS flow!");
                }
            }

        }
    }




}



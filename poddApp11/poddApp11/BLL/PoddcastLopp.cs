using poddAppen.DataLager;
using poddAppen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poddAppen.BLL
{
    public class PoddcastLopp : Podden, IEgenskap
    {
        public RssLasare lasRss = new RssLasare();

        public Dictionary<string, List<string>> AvsSammanfattning { get; set; } // (key, value) pair,,,get/set metoder

        public Dictionary<string, List<string>> Avsnitt { get; set; } // (key, value) pair,,,get/set metoder

        public string raknaAvsnitt { get; set; } // fält
        public string poddTitel { get; set; } // fält

        public PoddcastLopp()
        {
            Avsnitt = lasRss.Avsnitt;
            AvsSammanfattning = lasRss.AvsSammanfattning;
        }

        public async void laggTill(ListView list, string url, string frekvens, string kategori)
        {
            SparaXML sparaXml = new SparaXML();
            await lasRss.LaddaRss(url);
            sparaXml.SparaPodd(url, frekvens, kategori);
            raknaAvsnitt = lasRss.raknaAvsnitt;
            poddTitel = lasRss.poddTitel;
            base.laggTill(list, raknaAvsnitt, poddTitel, frekvens, kategori, url);
        }

        public async void laggTillPodd(ListView list)
        {
            List<ListViewItem> XmlPoddarLista = new List<ListViewItem>();
            LaddaXML laddaXmlFil = new LaddaXML();
            laddaXmlFil.LaddaPoddar(XmlPoddarLista);

            foreach (var item in XmlPoddarLista)
            {
                var url = item.SubItems[0].Text;
                var frekvens = item.SubItems[1].Text;
                var kategori = item.SubItems[2].Text;
                await lasRss.LaddaRss(url);
                poddTitel = lasRss.poddTitel;
                base.laggTill(list, raknaAvsnitt, poddTitel, frekvens, kategori, url);
            }
        }

        public void avsnittLista(ListView listViewPodcastAvsnitt, ListView listViewPodcast)
        {
            string podTitel = listViewPodcast.SelectedItems[0].SubItems[1].Text;
            foreach (var avsnitt in Avsnitt)
            {
                foreach (var value in avsnitt.Value)
                {
                    if (podTitel == avsnitt.Key)
                    {
                        base.laggTill(listViewPodcastAvsnitt, value);
                    }
                }
            }
        }

        public void sammanfattningsLista(ListView listViewPodcastAvsnitt, TextBox sammanFattning)
        {
            string avsnittTitel = listViewPodcastAvsnitt.SelectedItems[0].Text;
            foreach (var sammanfattning in AvsSammanfattning)
            {
                foreach (var sValue in sammanfattning.Value)
                {
                    if (poddTitel == sammanfattning.Key)
                    {
                        sammanFattning.Text = sValue;
                    }
                }
            }
        }


    }
}

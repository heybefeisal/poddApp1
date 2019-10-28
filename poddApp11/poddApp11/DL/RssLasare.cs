using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Windows.Forms;
using poddAppen.Interfaces;
namespace poddAppen.DataLager
{
    public class RssLasare : IEgenskap 
    { 
        public Dictionary<string, List<string>> AvsSammanfattning { get; set; } // (key, value) pair,,,get/set metoder

        public Dictionary<string, List<string>> Avsnitt { get; set; } // (key, value) pair,,,get/set metoder

        public string raknaAvsnitt { get; set; } // publik fält
        public string poddTitel { get; set; } // publik fält
        public string avsTitel { get; set; } // publik fält

        public RssLasare ()
        {
            Avsnitt = new Dictionary<string, List<string>>();
            AvsSammanfattning = new Dictionary<string, List<string>>();
        }
        private int antalObjekt(string flodeUrl)
        {
            using (XmlReader lasare = XmlReader.Create(flodeUrl))
            {
                return SyndicationFeed.Load(lasare).Items.Count();
            }
        }

        public async Task LaddaRss(string rssUrl)
        {
            await Task.Run(() => // det som speciferas läggs på kö och istället returneras en Task Objekt
            {
                try
                {
                    XmlReader lasare = XmlReader.Create(rssUrl); // skapar ny xmlReader instans med specificerad url
                    SyndicationFeed flode = SyndicationFeed.Load(lasare); // laddar en  syndikering flöde av specificerad xmlReader
                    lasare.Close(); // När overridden i en härledd klass, ändras XmlReader.ReadState till ReadState.Closed

                    raknaAvsnitt = antalObjekt(rssUrl).ToString(); // ändrar int till string
                    poddTitel = flode.Title.Text; 

                    foreach (SyndicationItem avsnitt in flode.Items) // SyndicationItem( representerar ett flöde objekt som tex RSS <objekt>
                    {
                        avsTitel = avsnitt.Title.Text;
                        string sammanfattning = avsnitt.Summary.Text; // lokal variabel

                        if(!AvsSammanfattning.ContainsKey(avsTitel)) // bestämmer om key/value innnehåller den specificerad key
                        {
                            AvsSammanfattning.Add(avsTitel, new List<string>()); // ADD-lägger till den specifierad key/value till Dictionary
                            AvsSammanfattning[avsTitel].Add(sammanfattning); // lägger till ett objekt till listan
                        }
                        if (!Avsnitt.ContainsKey(poddTitel)) // bestämmer om key/value innnehåller den specificerad key
                        {
                            Avsnitt.Add(poddTitel, new List<string>()); // lägger till ett objekt till listan
                            Avsnitt[poddTitel].Add(avsTitel); // lägger till ett objekt till listan
                        }
                        else
                        {
                            bool avsnittFinns = Avsnitt.Values.Any(value => value.Contains(avsTitel)); // bestämmer om några element av en sekvens stämmer överens av konditionen
                            bool sammFinns = AvsSammanfattning.Values.Any(value => value.Contains(sammanfattning)); // ,,
                            if(!avsnittFinns)
                            {
                                Avsnitt[poddTitel].Add(avsTitel); // lägger till ett objekt till listan
                            }
                            if(!sammFinns)
                            {
                                AvsSammanfattning[avsTitel].Add(sammanfattning); // lägger till ett objekt till listan
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Något har tyvärr gått fel"); // fel meddelande
                }
            });
        }

       


    }
}

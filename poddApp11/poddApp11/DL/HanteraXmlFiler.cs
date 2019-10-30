using poddApp11.BLL;
using poddAppen.BLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace poddApp11.DL
{
    public class HanteraXMLFiler
    {
        public static void skapaPoddLista()
        {
            if(File.Exists("poddar.txt"))
            {
                XDocument xmlDokument = XDocument.Load("poddar.txt");
                xmlDokument.Descendants("Podd").Select(podd => new
                {
                    url = podd.Element("Url").Value,
                    poddTitel = podd.Element("PoddTitel").Value,
                    uppFrekvens = Convert.ToInt32(podd.Element("UppFrekvens").Value),
                    kat = podd.Element("Kategori").Value,
                    antAvsnitt = Convert.ToInt32(podd.Element("AntAvsnitt").Value)
                }).ToList().ForEach(podd =>
                {
                    Podden podden = new Podden(podd.poddTitel, podd.uppFrekvens, podd.kat, podd.antAvsnitt, podd.url);
                    //Frekvens.Start(podd.poddTitel, podd.uppFrekvens, podd.kat, podd.kat);
                });
            }
        }

        public static void skapaAvsnittLista()
        {
            if (File.Exists("avsnitt.txt"))
            {
                XDocument xmlDokument = XDocument.Load("avsnitt.txt");
                xmlDokument.Descendants("avsnitt").Select(avs => new
                {
                    sammanfattning = avs.Element("sammanfattning").Value,
                    avsTitel = avs.Element("avsnittTitel").Value,
                    poddensTitel = avs.Element("poddTitel").Value,
                }).ToList().ForEach(avs =>
                {
                    Avsnitt avsnitt = new Avsnitt(avs.poddensTitel, avs.avsTitel, avs.sammanfattning);
                    AvsnittLista.laggTillAvsnitt(avsnitt);
                });
            }
        }

        public static void skapaKatLista()
        {
            if (File.Exists("kategori.txt"))
            {
                XDocument xmlDokument = XDocument.Load("kategori.txt");
                xmlDokument.Descendants("kategori").Select(kat => new
                {
                    katTitel = kat.Element("KategoriTitel").Value,
                }).ToList().ForEach(kat =>
                {
                    Kategori katten = new Kategori(kat.katTitel);
                    KategoriListor.laggTillKategori(katten);
                });
            }
        }

        public static void sparaPoddLista()
        {
            if(File.Exists("poddar.txt"))
            {
                File.Delete("poddar.txt");
            }
            using(Stream strom = File.OpenWrite(Environment.CurrentDirectory + "\\poddar.txt"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Podden>));
                ser.Serialize(strom, PoddLista.returneraLista());
                strom.Close();
            }
        }

        public static void sparaKatLista()
        {
            if (File.Exists("kategori.txt"))
            {
                File.Delete("kategori.txt");
            }
            using (Stream strom = File.OpenWrite(Environment.CurrentDirectory + "\\kategori.txt"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Podden>));
                ser.Serialize(strom, KategoriListor.hamtaKategoriLista());
                strom.Close();
            }
        }

        public static void sparaAvsnittListor()
        {
            if (File.Exists("avsnitt.txt"))
            {
                File.Delete("avsnitt.txt");
            }
            using (Stream strom = File.OpenWrite(Environment.CurrentDirectory + "\\avsnitt.txt"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Podden>));
                ser.Serialize(strom, AvsnittLista.hamtaAvsnittLista());
                strom.Close();
            }
        }


    }
}

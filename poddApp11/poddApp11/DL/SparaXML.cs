using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace poddAppen.DataLager
{
    class SparaXML
    {
        XDocument dokument;

        public void SparaPodd(string url, string Frekvens, string Kategori)
        {
            dokument = new XDocument(); // instansierar xmldokument klass
            dokument = XDocument.Load("Podd.xml"); // skapar ny xmldokument fil

            XElement nyPodd = new XElement("Podd");
            XElement UrL = new XElement("Url", url);
            XElement frekv = new XElement("Frek", Frekvens);
            XElement kat = new XElement("Kategori", Kategori);

            nyPodd.Add(UrL, frekv, kat); // Lägger till specificerad innehåll som children till XContainer
            dokument.Root.Add(nyPodd); // ,,
            dokument.Save("Podd.xml"); // Serialiserar xmlDokumenten till en fil, overwriting en existerande fil, om den existeras
        }

        public void sparaKat(List<string> kategori)
        {
            dokument = new XDocument(); // instansierar xmldokument klass
            XElement nyKategori = new XElement("Kategorier");

            foreach(var kat in kategori)
            {
                nyKategori.Add(new XElement("Kategori", kat)); // Lägger till specificerad innehåll som children till XContainer
            }
            dokument.Add(nyKategori); // Lägger till specificerad innehåll som children till XContainer
            dokument.Save("kategori.xml"); // Serialiserar xmlDokumenten till en fil, overwriting en existerande fil, om den existeras
        }
    }
}

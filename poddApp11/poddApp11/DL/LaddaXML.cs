using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace poddAppen.DataLager
{
    class LaddaXML
    {
        public void LaddaKategori(List<string> kategorier)
        {
            XmlDocument dokument = new XmlDocument(); // instansierar xmldokument klass
            dokument.Load("Kategorier.xml"); // laddar specificerad xml fil från angett url
            var kategoriElement = dokument.GetElementsByTagName("Kategori"); // hämtar lista

            for(int i = 0; i < kategoriElement.Count; i++)
            {
                kategorier.Add(kategoriElement[i].InnerText); // lägger till element i lista
            }
        }

        public void LaddaPoddar(List<ListViewItem> XmlPoddarLista)
        {
            XmlDocument dokument = new XmlDocument();
            dokument.Load("Poddar.xml"); // laddar specificerad xml fil från angett url

            var urlElement = dokument.GetElementsByTagName("Url"); // hämtar element i lista som matchar xmldokument namn
            var frekvensElement = dokument.GetElementsByTagName("Frekvens"); // ,,
            var kategoriElement = dokument.GetElementsByTagName("Kategori"); // ,,

            for(int i = 0; i < urlElement.Count; i ++)
            {
                var listViewItem = new ListViewItem(new[]
                {
                    urlElement[i].InnerText,
                    frekvensElement[i].InnerText,
                    kategoriElement[i].InnerText
                });
                XmlPoddarLista.Add(listViewItem); // lägger till element i lista
            }
        }
    }
}

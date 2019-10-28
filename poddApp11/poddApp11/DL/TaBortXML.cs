using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace poddAppen.DataLager
{
    class TaBortXML
    {
        public void taBortPodd(string urlKod, string uppdatering, string kategori)
        {
            XDocument dokument = XDocument.Load("Podd.xml");                // XDocument rep en XDocumentKlass. 
            var pod = from node in dokument.Descendants("Pod")              // från varje elemement i XDoucument klass Pod
                      let UrlKod = node.Element("UrlKod")                             // let används för att ställa frågan flera ggr
                      let Uppdatering = node.Element("Uppdatering")
                      let Kategori = node.Element("Kategori")
                      where UrlKod != null && UrlKod.Value == urlKod                  // kollar så att det inte är null och att det stämmer med parameter värdet
                      where Uppdatering != null && Uppdatering.Value == uppdatering
                      where Kategori != null && Kategori.Value == kategori
                      select node;                                                    // välj denna där detta stämmer
            pod.ToList().ForEach(xmlList => xmlList.Remove());              // För varje podd i listan som dettta stämmer. ta bort elementet
            dokument.Save("Podd.xml")                                       // spara uppdateringen i listan. 
        }

    }
}

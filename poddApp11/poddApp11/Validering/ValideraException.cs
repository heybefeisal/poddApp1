using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace poddAppen.BLL
{
    class ValideraException
    {
        ValideraMeddelanden meddelande = new ValideraMeddelanden();

       public bool RattUrl(string url)
        {
            try
            {
                XmlReader lasare = XmlReader.Create(url);
                Rss20FeedFormatter form = new Rss20FeedFormatter();
                form.ReadFrom(lasare);
                lasare.Close();
                return true;
            }
            catch(Exception)
            {
                meddelande.giltigUrl();
                return false;
            }
        }
        
        public bool TomBox(ComboBox box)
        {
            if(box.SelectedItem == null)
            {
                meddelande.tomFrekvens();
                return false; 
            }
            else
            {
                return true;
            }
        }
        
        public bool IckeVald(ListView list)
        {
            if(0 < list.SelectedItems.Count)
            {
                return true;
            }
            else
            {
                meddelande.IngetVald();
                
                return false;
            }
        }
        
        public bool IckeTomKat(TextBox textBox)
        {
            if(string.IsNullOrWhiteSpace(textBox.Text))
            {
                meddelande.tomKategori();
                return false;
            }
            else
            {
                return true;
            }
        }
             
        public bool IckeTomUrl(TextBox textBox)
        {
            if(string.IsNullOrWhiteSpace(textBox.Text))
            {
                meddelande.tomUrl();
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool UrlFinns(Dictionary<string, Timer> tid, string url)
        {
            foreach ( var objekt in tid)
            {
                if(objekt.Key == url)
                {
                    meddelande.urlFinnsRedan();
                    return false;
                }
            }
            return true;
        }

    }
}

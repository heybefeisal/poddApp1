using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace poddApp11.BLL
{
    class ValideraKod
    {


        public static bool korrektRss(string url)
        {
            try
            {
                var feed = SyndicationFeed.Load(XmlReader.Create(url));

                Console.WriteLine("Länken funkar!");

                return true;

            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Länken funkar ej!");

                return false;
            }
        }


        public bool korrektUrl(string valid)
        {
            if (string.IsNullOrWhiteSpace(valid))
            {

                return false;
            }
            else
            {
                return true;
            }
        }

        public bool korrektKat(string valid)
        {
            if (string.IsNullOrEmpty(valid))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }




}


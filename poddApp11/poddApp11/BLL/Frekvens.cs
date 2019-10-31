using poddApp11.DL;
using poddAppen.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace poddApp11.BLL
{
    public class UFrekvens
    {

        public static event EventHandler FangaUppdatering;

        public static Boolean AndraTid(ListViewItem list)
        {

            switch (list.SubItems[2].Text)
            {
                case "Månad":
                    return DateTime.Parse(list.SubItems[5].Text).AddMonths(1) > DateTime.Now.ToUniversalTime();


                case "Vecka":
                    return DateTime.Parse(list.SubItems[5].Text).AddDays(7) > DateTime.Now.ToUniversalTime();


                case "Dag":
                    return DateTime.Parse(list.SubItems[5].Text).AddDays(1) > DateTime.Now.ToUniversalTime();


                case "Timme":
                    return DateTime.Parse(list.SubItems[5].Text).AddMinutes(60) > DateTime.Now.ToUniversalTime();


                case "Minut":
                    return DateTime.Parse(list.SubItems[5].Text).AddMinutes(1) > DateTime.Now.ToUniversalTime();


                default:
                    return false;
            }
        }
      

        private static int startaVagen(int frekvens)
        {
            int frekvensMin = frekvens * 1000;
            return frekvensMin;
        }

        public static void First(string title, string url, int frekvens, string kategori)
        {
            int FrekvensMinut = startaVagen(frekvens);
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += (sender, e) => Time(sender, e, title, frekvens, url, kategori);
            timer.Interval = FrekvensMinut;
            timer.Enabled = true;
        }

        private static async void Time(object kod, ElapsedEventArgs e, string title, int frekvens, string url, string kategori)
        {
            List<Podden> list = PoddLista.returneraLista();
            Boolean here = false;
            foreach (var podcast in list.Where(podd => podd.PoddTitel == title))
            {
                here = true;
            }
            if (here)
            {
                int xAntalAvsnitt = 0;
                string poddTitel = "";
                int i = 0;
                int nyFrekvens = 0;
                foreach (var podcast in list.Where(podd => podd.PoddTitel.Equals(title)))
                {
                    xAntalAvsnitt = podcast.AnAvsnitt;
                    poddTitel = podcast.PoddTitel;
                    nyFrekvens = podcast.uppFrek;
                    i++;
                }
                int nyttAvs = await lassRss.hamtaAvRss(url);

                Console.WriteLine("Söker efter nya avsnitt...");
                if (nyttAvs == xAntalAvsnitt)
                {
                    Console.WriteLine(title + " Det finns inga nya avsnitt!");
                }

                else
                {
                    AvsnittLista.taBortAvs(poddTitel);
                    PoddLista.taBortPodd(poddTitel);
                    EnVag.laggTillPodd(url, frekvens, kategori);
                    FangaUppdatering(kod, e);
                    Console.WriteLine("Listan är uppdaterad!");
                }
            }
        }
    }
}

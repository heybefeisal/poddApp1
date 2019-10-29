using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poddAppen.BLL
{
    public class ValideraMeddelanden
    {
        public void IngetVald()
        {
            MessageBox.Show("Markera den du vill ta-bort/ändra");
        }

        public void tomUrl()
        {
            MessageBox.Show("Fyll i url fältet");
        }

        public void giltigUrl()
        {
            MessageBox.Show("Fyll i giltig Rss-url!");
        }

        public void urlFinnsRedan()
        {
            MessageBox.Show("Podd url har redan lagts till");
        }

        public void tomFrekvens()
        {
            MessageBox.Show("Ange uppdateringsintervall");
        }

        public void tomKategori()
        {
            MessageBox.Show("Tom kategori fält");
        }
    }
}

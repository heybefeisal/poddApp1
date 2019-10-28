using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poddAppen.BLL
{
    public abstract class Podden
    { 
        public virtual void laggTill(ListView list, string avsnittRaknare, string poddTitel, string frekvens, string kategori, string url )
        {
            var listVItem = new ListViewItem(new[] {
                avsnittRaknare,
                poddTitel,
                frekvens,
                kategori
            });
            list.Items.Add(listVItem);
            listVItem.Tag = url;
        }

        public virtual void laggTill(ListView list, string objekt)
        {
            var listVItem = new ListViewItem(new[]
            {
                objekt,
            });
            list.Items.Add(listVItem);
        }

        public virtual void taBort(ListView list)
        {
            list.SelectedItems[0].Remove();
        }

        public virtual void sparaAndring(ListView listViewKategori, TextBox textBox)
        {
            listViewKategori.SelectedItems[0].Text = textBox.Text;
        }
    }
}

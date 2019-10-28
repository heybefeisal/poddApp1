using poddAppen.DataLager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poddAppen.BLL
{
    class Kategori : Podden
    {
        public List<string> KategoriLista = new List<string>();

        SparaXML sparaXML = new SparaXML();


        public void LaggTillKatXML(ListView list)
        {
            LaddaXML laddaXML = new LaddaXML();
            laddaXML.LaddaKategori(KategoriLista);

            foreach (var kategori in KategoriLista)
            {
                base.laggTill(list, kategori);
            }
        }

        public override void laggTill(ListView list, string objekt)
        {
            string kategori = objekt;
            KategoriLista.Add(kategori);
            sparaXML.sparaKat(KategoriLista);
            base.laggTill(list, kategori);
        }

        public override void taBort(ListView list)
        {
            KategoriLista.Remove(list.SelectedItems[0].Text);
            sparaXML.sparaKat(KategoriLista);
            base.taBort(list); 
        }

        public override void sparaAndring(ListView listViewKategori, TextBox textBox)
        {
            string nyKategori = textBox.Text;
            KategoriLista.Remove(listViewKategori.SelectedItems[0].Text);
            KategoriLista.Add(nyKategori);
            sparaXML.sparaKat(KategoriLista);
            base.sparaAndring(listViewKategori, textBox);
        }

    }
}


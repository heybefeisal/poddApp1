using poddApp11.BLL;
using poddAppen.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace poddApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs ev)
        {
            UFrekvens frekvens = new UFrekvens();
            new PoddLista();
            new AvsnittLista();
            new KategoriListor();

            EnVag.skapaLista();

            UppdateraPoddListView();
            UppdateraKategori1();
            UppdateraKategori2();
          frekvens..FangaUppdatering += new EventHandler(FangaEventen); 

        }

        void FangaEventen(object sender, EventArgs e)
        {
            if(this.InvokeRequired)
            {
                this.Invoke(new Action(() => UppdateraPoddListView()));
            }
            else
            {
                UppdateraPoddListView();
            }
        }

        private void buttonLaggTillPodd_Click(object sender, EventArgs e)
        {
            var url = textBoxUrl.Text;
            int uppFrekvens = Convert.ToInt32(comboBoxUppdatering.Text.Split(' ')[0]);
            var kategori = comboBoxKategori.Text;

            BLL.EnVag.laggTillPodd(url, uppFrekvens, kategori);
            UppdateraPoddListView();
        }

        public void UppdateraPoddListView()
        {
            List<Podden> poddLista = PoddLista.returneraLista();
            listViewPoddar.Items.Clear();

            foreach (var podd in poddLista)
            {
                var poddList = new ListViewItem(new[]
                {
                    podd.PoddTitel,
                    podd.Kategorier,
                    podd.AnAvsnitt.ToString(),
                    podd.uppFrek.ToString() + "minuter"
                });
                listViewPoddar.Items.Add(poddList);
            }

        }

        public void UppdateraPoddListViewKat(string kat)
        {
            List<Podden> poddLista = PoddLista.returneraLista();
            listViewPoddar.Items.Clear();

            foreach (var podd in poddLista.Where(podd => podd.Kategorier == kat))
            {
                var poddList = new ListViewItem(new[]
                {
                    podd.PoddTitel,
                    podd.Kategorier,
                    podd.AnAvsnitt.ToString(),
                    podd.uppFrek.ToString() + "minuter"
                });
                listViewPoddar.Items.Add(poddList);
            }
        }

        private void UppdateraAvsListView(string poddTiteln)
        {
            List<Avsnitt> avsLista = AvsnittLista.hamtaAvsnittLista().Where(titeln => titeln.PoddTitel == poddTiteln).ToList();
            listViewPoddarAvsnitt.Items.Clear();
            foreach (var ettAvsnitt in avsLista)
            {
                var lista = new ListViewItem(new[]
                {
                    ettAvsnitt.AvsTitel
                });
            listViewPoddarAvsnitt.Items.Add(lista);
            }
        }

        private void UppdateraBeskrivning(string ettAvsnitt)
        {
            List<Avsnitt> avsLista = AvsnittLista.hamtaAvsnittLista().Where(titeln => titeln.AvsTitel == ettAvsnitt).ToList();

            foreach(var avsnitten in avsLista)
            {
                textBoxAvsSammanfattning.Text = avsnitten.hamtaInfo();
            }
        }

        public void UppdateraKategori1()
        {
            listBox1.Items.Clear();

            foreach(var kategori in KategoriListor.hamtaKategoriLista())
            {
                listBox1.Items.Add(kategori.KTitel);
            }
        }

        public void UppdateraKategori2()
        {
            comboBoxKategori.Items.Clear();

            foreach (var kategori in KategoriListor.hamtaKategoriLista())
            {
                comboBoxKategori.Items.Add(kategori.KTitel);
            }
        }

        public void sparaKategorier(string sparaKat)
        {
            string fdKategori = listBox1.GetItemText(listBox1.SelectedItem);

            if(string.IsNullOrEmpty(fdKategori))
            {
                System.Windows.Forms.MessageBox.Show("Markerad");
                return;
            }

            foreach(var kategori in KategoriListor.hamtaKategoriLista().Where(kategori => kategori.KTitel.Equals(fdKategori)))
            {
                kategori.KTitel = sparaKat;
            }

            UppdateraKategori1();
            UppdateraKategori2();
        }

        public void UppdateraPodd(string poddTiteln)
        {
            string url = textBoxUrl.Text;
            int frekvens = Convert.ToInt32(comboBoxUppdatering.Text.Split(' ')[0]);
            string kategori = listBox1.Text;

            PoddLista.taBortPodd(poddTiteln);
            AvsnittLista.taBortAvs(poddTiteln);
            EnVag.laggTillPodd(url, frekvens, kategori);

            UppdateraPoddListView();
            listViewPoddarAvsnitt.Items.Clear();
        }

        private void listViewPoddar_ItemActivate(object sender, EventArgs e)
        {
            var index = this.listViewPoddar.SelectedIndices[0];
            buttonSparaPodd.Enabled = true;
            buttonTaBortPodd.Enabled = true;
            string podTitel = this.listViewPoddar.Items[index].SubItems[0].Text;
            sparaKategorier(podTitel);

            UppdateraAvsListView(podTitel);
        }

        private void buttonLaggTillKat_Click(object sender, EventArgs e)
        {
            var textBKategori = textBoxKategori.Text;

            if(string.IsNullOrEmpty(textBKategori))
            {
                System.Windows.Forms.MessageBox.Show("Var snäll att fyll textfältet");
                return;
            }

            Kategori kat = new Kategori(textBKategori);
            KategoriListor.laggTillKategori(kat);
            UppdateraKategori1();
            UppdateraKategori2();
        }

        private void lbKategorier_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kategori = listBox1.GetItemText(listBox1.SelectedItem);
            textBoxKategori.Text = kategori;
            UppdateraPoddListViewKat(kategori);
        }

        private void btnSparaKat_Click(object sender, EventArgs e)
        {
            var sparaKat = textBoxKategori.Text;
            sparaKategorier(sparaKat);
        }

        private void buttonTaBortKat_Click(object sender, EventArgs e)
        {
            try
            {
                var kat = listBox1.GetItemText(listBox1.SelectedItem);
                int i;
                List<Kategori> kLista = KategoriListor.hamtaKategoriLista();
                i = kLista.FindIndex(l => l.KTitel.Equals(kat));
                kLista.RemoveAt(i);
                UppdateraKategori1();
                UppdateraKategori2();


            } catch(Exception)
            {
                System.Windows.Forms.MessageBox.Show("Markera Kategori för att ta bort");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs fe)
        {
            EnVag.sparaLista();
        }

        private void buttonTaBortPodd_Click(object sender, EventArgs e)
        {
            var pTitel = "";
            try
            {
                pTitel = listViewPoddar.SelectedItems[0].Text;
                PoddLista.taBortPodd(pTitel);
                AvsnittLista.taBortAvs(pTitel);
                UppdateraPoddListView();
            } catch(Exception)
            {
                System.Windows.Forms.MessageBox.Show("Markera podd för att ta bort");
            }
        }

        private void buttonSparaPodd_Click(object sender, EventArgs e)
        {
            string pTitel = "";
            try
            {
                var index = listViewPoddar.SelectedIndices[0];
                pTitel = listViewPoddar.Items[index].SubItems[0].Text;
                UppdateraPodd(pTitel);
            }
            catch(Exception)
            {
                System.Windows.Forms.MessageBox.Show("Markera podd för att redigera");
            }
        }

        private void listBox1_Leave(object sender, EventArgs e)
        {
            UppdateraPoddListView();
        }

       
        private void listViewPoddar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxUppdatering_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonLaggTillPodd_Click_1(object sender, EventArgs e)
        {
            var url = textBoxUrl.Text;
            int uppFrekvens = Convert.ToInt32(comboBoxUppdatering.Text.Split(' ')[0]);
            var kategori = comboBoxKategori.Text;

            BLL.EnVag.laggTillPodd(url, uppFrekvens, kategori);
            UppdateraPoddListView();
        }

        private void buttonTaBortPodd_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxUrl_TextChanged(object sender, EventArgs e)
        {

        }

 
    }
}

using poddApp11.DL;


namespace poddAppen.BLL
{
    public class Podden : IInterface 
    { 
        private string url { get; set; }

        private string poddTitel { get; set; }

        private int uppFrekvens { get; set; }

        private string kategori { get; set; }

        private int antalAvs { get; set; }

        public Podden(string poddensTitel, int frek, string kategori, int antalAv, string url)
        {
            poddTitel = poddensTitel;
            uppFrekvens = frek;
            this.kategori = kategori;
            this.antalAvs = antalAv;
            this.url = url;


        }

        public Podden()
        {

        }

        public string PoddTitel
        {
            get => poddTitel;
            set => poddTitel = value;
        }

        public int uppFrek
        {
            get => uppFrekvens;
            set => uppFrekvens = value;
        }

        public string Kategorier
        {
            get => kategori;
            set => kategori = value;
        }

        public string Url
        {
            get => url;
            set => url = value;
        }

        public int AnAvsnitt
        {
            get => antalAvs;
            set => antalAvs = value;
        }

    }

    
}

using poddApp11.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poddApp11.BLL
{
    public class Avsnitt : AvsnitssInformation, IInterface  
    {
        private string poddTitel;
        private string avsTitel;
        private string sammanfattning;


        public Avsnitt(string poddTitel, string avsTitel, string sammanfattning) : base(poddTitel, avsTitel, sammanfattning)
        {
            this.poddTitel = poddTitel; 
            this.avsTitel = avsTitel;
            this.sammanfattning = sammanfattning;
        }

        public Avsnitt()
        {

        }

        public string PoddTitel
        {
            get => poddTitel;
            set => poddTitel = value;
        }

        public string AvsTitel
        {
            get => avsTitel;
            set => avsTitel = value;
        }

        public string Sammmanfattning
        {
            get => sammanfattning;
            set => sammanfattning = value;
        }
    }
}

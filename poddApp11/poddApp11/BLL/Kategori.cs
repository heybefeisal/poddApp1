using poddApp11.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poddAppen.BLL
{
    public class Kategori 
    {

        private string katTitel { get; set; }

        public Kategori(string kategori)
        {
            katTitel = kategori;
        }

        public string KTitel
        {
            get => katTitel;
            set => katTitel = value;
        }


    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poddApp11.BLL
{
    public class AvsnitssInformation
    {
        private string poddTitel;
        private string avsTitel;
        private string sammanfattning;

        public AvsnitssInformation(string poddTitel, string avsTitel, string sammanfattning)
        {
            this.poddTitel = poddTitel;
            this.avsTitel = avsTitel;
            this.sammanfattning = sammanfattning;
        }

        public AvsnitssInformation()
        {

        }

        public virtual string hamtaInfo()
        {
            string nyLinje = "\r\n";
            return avsTitel + nyLinje + sammanfattning + "Override det här!!!!!!!!!";
        }
    }
}

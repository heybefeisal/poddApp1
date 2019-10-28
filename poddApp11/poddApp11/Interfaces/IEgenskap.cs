using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poddAppen.Interfaces
{
    interface IEgenskap
    {
        Dictionary<string, List<string>> AvsSammanfattning { get; set; } // (key, value) pair,,,get/set metoder

        Dictionary<string, List<string>> Avsnitt { get; set; } // (key, value) pair,,,get/set metoder

        string raknaAvsnitt { get; set; } // fält
        string poddTitel { get; set; } // fält
    }
}

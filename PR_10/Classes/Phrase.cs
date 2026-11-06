using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_10.Classes
{
    public class Phrase
    {
        public string _Phrase { get; set; }
        public string Src { get; set; }
        public Phrase (string Phrase, string Src)
        {
            this._Phrase = Phrase;
            this.Src = Src;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Text;
using System.Threading.Tasks;

namespace PR_10.Classes
{
    public abstract class Human
    {
        public string Name { get; set; }
        public string Img { get; set; }
        public Human(string name, string img)
        {
           this.Name = name;
            this.Img = img;
        }
        public abstract void Speak(Label Phrase);
    }
}

using PR_10.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_10.Classes
{
    internal class English:Human
    {
        private List<Phrase> Phrases { get; set; }


        private int stepAudio;
        private int StepAudio
        {
            get { return stepAudio; }
            set
            {
                stepAudio = value;

                if (stepAudio > Phrases.Count - 1)

                    stepAudio = 0;
            }
        }
        public English(string Name, string Img) : base(Name, Img)
        {

            this.Phrases = AllPhrases();
        }


        public override void Speak(Label Phrase)
        {
            Phrase.Content = Phrases[StepAudio]._Phrase;

            MainWindow.MediaPlayer.Open(new Uri(Phrases[StepAudio].Src, UriKind.Relative));
            MainWindow.MediaPlayer.Play();

            StepAudio++;
        }


        public static List<Phrase> AllPhrases()
        {

            List<Phrase> allPhrases = new List<Phrase>();

            allPhrases.Add(new Phrase("Priviet", @"C:\Users\levne\source\repos\PR_10\PR_10\Voices\privet.mp3"));
            allPhrases.Add(new Phrase("kak dela?", @"C:\Users\levne\source\repos\PR_10\PR_10\Voices\kak_dela.mp3"));
            allPhrases.Add(new Phrase("menia zovut ivan.", @"C:\Users\levne\source\repos\PR_10\PR_10\Voices\optimus_prime.mp3"));

            return allPhrases;
        }
    
}
}

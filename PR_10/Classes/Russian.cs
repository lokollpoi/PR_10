using PR_10.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PR_10
{
    public class Russian : Human
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
        public Russian(string Name, string Img) : base(Name, Img)
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

            allPhrases.Add(new Phrase("Привет", @"Voices\privet.wav"));
            allPhrases.Add(new Phrase("Как дела?", @"Voices\kak_dela.wav"));
            allPhrases.Add(new Phrase("Меня зовут ОПТИМУС ПРАЙМ.", @"Voices\optimus_prime.wav"));
  
            return allPhrases;
        }
    }

}

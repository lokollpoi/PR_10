using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR_10.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        Classes.Human Human;

        public Item(object Data)
        {
            InitializeComponent();
            // Запоминаем объект, для того чтобы в последующем обратиться к нему
            this.Human = Data as Classes.Human;

            img.Source = new BitmapImage(new Uri(this.Human.Img));

            name.Content = this.Human.Name;
   
            lrace.Content = Data.GetType().Name;
        }

        /// <summary> Метод воспроизведения фраз
        private void Speak(object sender, MouseButtonEventArgs e)
        {
            Human.Speak(text);
        }
    }
}

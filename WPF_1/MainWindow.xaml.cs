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

namespace WPF_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Lottery Lottery;
        public MainWindow()
        {
            InitializeComponent();
            Lottery = new Lottery();
        }

        private void Button_Click_Wrzuc(object sender, RoutedEventArgs e)
        {
            string word = Input.Text;
            Lottery.Insert(word);
            Input.Text = "Wpisz słowo";
        }

        private void Button_Click_Wyjmij(object sender, RoutedEventArgs e)
        {
            if (Lottery.IsEmpty() == false)
            {
                Label.Content = Lottery.TakeOutAndDelete();
            }

        }
    }
}

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
using System.Windows.Shapes;

namespace Assignment_03
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Lunch l1 = new Lunch();
            this.Close();
            l1.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Dinner d1 = new Dinner();
            this.Close();
            d1.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow l1 = new MainWindow();
            this.Close();
            l1.Show();
        }
    }
}

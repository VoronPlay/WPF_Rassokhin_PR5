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

namespace WPF_Rassokhin_PR5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            cat_1.Source = new BitmapImage(new Uri("Images/cat_1", UriKind.Relative));
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            cat_2.Source = new BitmapImage(new Uri("Images/cat_2", UriKind.Relative));
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            cat_3.Source = new BitmapImage(new Uri("Images/cat_3", UriKind.Relative));
        }
    }
}

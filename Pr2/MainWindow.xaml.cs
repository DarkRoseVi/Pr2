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
using Pr2.Models;
using Pr2.Windows;

namespace Pr2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LIstProdLw.ItemsSource = App.db.Product.ToList();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            var product = (sender as Button).DataContext as Product;
            var dialog = new EditWindow(product).ShowDialog();
            LIstProdLw.ItemsSource = App.db.Product.ToList();
        }

        private void DeletBtn_Click(object sender, RoutedEventArgs e)
        {
            var product = (sender as Button).DataContext as Product;
            var dialog = new DeleteWindow(product).ShowDialog();
            LIstProdLw.ItemsSource = App.db.Product.ToList();

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new AddWindow().ShowDialog();
                LIstProdLw.ItemsSource = App.db.Product.ToList();

        }
    }
}

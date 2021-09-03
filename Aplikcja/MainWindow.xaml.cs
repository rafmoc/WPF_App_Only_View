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

namespace Aplikcja
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new MainPage();
        }
        public void HomePage(object sender, RoutedEventArgs e)
        {
            Main.Content = new MainPage();
        }
        public void CiList(object sender, RoutedEventArgs e)
        {
            Main.Content = new Configuration.CiList();
        }
        public void DpEpMatching(object sender, RoutedEventArgs e)
        {
            Main.Content = new Configuration.DpEpMatch();
        }
        public void CiNew(object sender, RoutedEventArgs e)
        {
            Main.Content = new Configuration.CInew();
        }
        public void PaList(object sender, RoutedEventArgs e)
        {
            Main.Content = new PA.PaList();
        }
        public void PaCiMatching(object sender, RoutedEventArgs e)
        {
            Main.Content = new PA.PaCiMatch();
        }

        //----------------------------------------------------------

        private void CardStockCardNew(object sender, RoutedEventArgs e)
        {
            Main.Content = new CardStock.New();
        }
        private void CardStockCardImport(object sender, RoutedEventArgs e)
        {
            Main.Content = new CardStock.Import();
        }
        private void CardStockCardExport(object sender, RoutedEventArgs e)
        {
            Main.Content = new CardStock.Export();
        }
        private void CardStockCardTests(object sender, RoutedEventArgs e)
        {
            Main.Content = new CardStock.CardTests();
        }
        public void CardStockCardOrders(object sender, RoutedEventArgs e)
        {
            Main.Content = new CardStock.CardOrders();
        }
        public void CardStockCardList(object sender, RoutedEventArgs e)
        {
            Main.Content = new CardStock.CardList();
        }
    }
}



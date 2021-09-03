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

namespace Aplikcja.CardStock
{
    public partial class CardOrders : Page
    {
        private MainWindow mainWindow;
        public CardOrders()
        {
            InitializeComponent();

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    mainWindow = (MainWindow)window;
                }
            }
        }

        private void CardStockCardNew(object sender, RoutedEventArgs e)
        {
            mainWindow.Main.Content = new CardStock.New();
        }
        private void CardStockCardImport(object sender, RoutedEventArgs e)
        {
            mainWindow.Main.Content = new CardStock.Import();
        }
        private void CardStockCardExport(object sender, RoutedEventArgs e)
        {
            mainWindow.Main.Content = new CardStock.Export();
        }
        private void CardStockCardTests(object sender, RoutedEventArgs e)
        {
            mainWindow.Main.Content = new CardStock.CardTests();
        }
        private void CardStockCardOrders(object sender, RoutedEventArgs e)
        {
            mainWindow.Main.Content = new CardStock.CardOrders();
        }
        private void CardStockCardList(object sender, RoutedEventArgs e)
        {
            mainWindow.Main.Content = new CardStock.CardList();
        }
    }
}

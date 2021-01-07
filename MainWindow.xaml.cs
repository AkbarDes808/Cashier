using System;
using System.Collections;
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

namespace Kasir_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            Menu.ItemsSource = LoadMenuData();
            Diskon.ItemsSource = LoadDiskonData();
            

        }
        private ArrayList LoadMenuData()
        {
            ArrayList itemsList = new ArrayList();
            itemsList.Add("Coffie Latte"+ Environment.NewLine +"Rp30000");
            itemsList.Add("Black Tea" + Environment.NewLine +"Rp20000");
            itemsList.Add("Pizza" + Environment.NewLine +"Rp75000");
            itemsList.Add("Milk Shake" + Environment.NewLine +"Rp15000");
            itemsList.Add("Fried Frice Special" + Environment.NewLine +"Rp45000");
            itemsList.Add("Watermelon Juice" + Environment.NewLine +"Rp25000");
            itemsList.Add("Lemon Squash" + Environment.NewLine +"Rp30000");
            return itemsList;
        }
        private ArrayList LoadDiskonData()
        {
            ArrayList itemsList = new ArrayList();
            itemsList.Add("Diskon 1" + Environment.NewLine + "Rp30000");
            itemsList.Add("Diskon 2" + Environment.NewLine + "Rp20000");
            itemsList.Add("Diskon 3" + Environment.NewLine + "Rp75000");
            return itemsList;
        }


            private void Menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Keranjang.Items.Add(Menu.SelectedItem);
        }

        private void OnClickMouse(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Kamu ingin menghapus item ini?",
                    "Konfirmasi", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Keranjang.Items.Remove(Keranjang.SelectedItem);
            }
        }

        private void Keranjang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
        private void Diskon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Total.Items.Add(Diskon.SelectedItem);
            
        }
    }
}

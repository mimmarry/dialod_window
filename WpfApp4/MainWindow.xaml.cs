using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfApp4.Forms;
using WpfApp4.Models;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<Bad> ListBads { get; set; }
        public Bad SelectedBad { get; set; }
        
        public MainWindow()
        {
            ListBads = new();
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            DialogAddtem add = new DialogAddtem();
            add.ShowDialog();

            ListBads.Add(add.Bad);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (SelectedBad == null)
                return;

            DialogAddtem dialog = new DialogAddtem(SelectedBad);
            dialog.ShowDialog();

            ListBads.Add(dialog.Bad);
        }
    }
}

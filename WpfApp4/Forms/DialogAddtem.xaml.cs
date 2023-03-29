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
using WpfApp4.Models;

namespace WpfApp4.Forms
{
    /// <summary>
    /// Логика взаимодействия для DialogAddtem.xaml
    /// </summary>
    public partial class DialogAddtem : Window
    {
        public Bad Bad { get; set; }
        public DialogAddtem()
        {
            InitializeComponent();
            Bad = new Bad();


            DataContext = Bad;
        }
        public DialogAddtem(Bad bad)
        {
            InitializeComponent();
            Bad = Bad;
            DataContext = Bad;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данные успешно занесены!");
            this.Close();
        }
    }
}

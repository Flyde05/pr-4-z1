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

namespace prak_3_zd_1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(month.Text, out int mon))
            { }
            if (int.TryParse(result.Text, out int res))
            { }
            if (mon < 0 || mon > 12)
            {
                MessageBox.Show("Ошибка");
            }
            switch (mon)
            {
                case 1:
                    result.Text = ("зима");
                    break;
                case 2:
                    result.Text = ("зима");
                    break;
                case 3:
                    result.Text = ("весна");
                    break;
                case 4:
                    result.Text = ("весна");
                    break;
                case 5:
                    result.Text = ("весна");
                    break;
                case 6:
                    result.Text = ("лето");
                    break;
                case 7:
                    result.Text = ("лето");
                    break;
                case 8:
                    result.Text = ("лето");
                    break;
                case 9:
                    result.Text = ("осень");
                    break;
                case 10:
                    result.Text = ("осень");
                    break;
                case 11:
                    result.Text = ("осень");
                    break;
                case 12:
                    result.Text = ("зима");
                    break;




            }
        }
    }
}
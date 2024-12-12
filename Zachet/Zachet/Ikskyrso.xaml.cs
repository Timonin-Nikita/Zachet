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

namespace Zachet
{
    /// <summary>
    /// Логика взаимодействия для Ikskyrso.xaml
    /// </summary>
    public partial class Ikskyrso : Window
    {
        public Ikskyrso()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Ikskyrso ikskyrso = new Ikskyrso();
            ikskyrso.Show();
            this.Close();
        }
    }
}

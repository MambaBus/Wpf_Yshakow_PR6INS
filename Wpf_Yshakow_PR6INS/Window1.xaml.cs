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

namespace Wpf_Yshakow_PR6INS
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        DateTime d1;
        DateTime d2;


        private void data1_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            d1 = data1.SelectedDate.Value;
        }

        private void data2_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            d2 = data2.SelectedDate.Value;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan x = d2 - d1;
            label1.Content = x;
        }
    }
}

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

namespace Wpf_Yshakow_PR6INS
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
        string login1;
        string password1;
        string a = "admin";
        string b = "admin";

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            login1 = login.Text;
            password1 = password.Text;



            if (login1 != a && password1 != b)
            {
                MessageBox.Show("Неверные логин и пароль");
            }

            else if (password1 != b)
            {
                MessageBox.Show("Неверный пароль");
            }

            else if (login1 != a)
            {
                MessageBox.Show("Неверный логин");
            }

            else if (login1 == a && password1 == p)
            {
                Window1 window1 = new Window1();
                window1.Show();
                mainWind.Close();
            }
    }
}

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

namespace WpfApp1
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

        private void MICloseClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void EnterClick(object sender, RoutedEventArgs e)
        {
            password.Text = passBox.Password;
            if (login.Text == "privet" && password.Text == "poka")
            {
                MessageBox.Show("Вы успешно авторизовались.");
                Progr Progr = new Progr();
                Progr.Show();
                Close();
            }
            else MessageBox.Show("Введен не верный логин или пароль! Попробуйте еще раз.");
        }

        private void PassVisibleChecked(object sender, RoutedEventArgs e)
        {
            passBox.Visibility = Visibility.Hidden;
            password.Text = passBox.Password;
        }

        private void passVivibleUnchecked(object sender, RoutedEventArgs e)
        {
            passBox.Visibility = Visibility.Visible;
            passBox.Password = password.Text;
        }
    }
}

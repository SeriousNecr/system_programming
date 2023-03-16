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

namespace Gorkogo
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

        private void AvtorizaciaClick(object sender, RoutedEventArgs e)
        {
            var cur = AppDatas.db.Сотрудники.FirstOrDefault(u => u.Логин == login.Text && u.Пароль == pass.Text && u.Должность == "Продавец");
            if (cur != null)
            {
                WorkWin workWin = new WorkWin();
                workWin.Show();
                Close();
            }
            else
            {
                cur = AppDatas.db.Сотрудники.FirstOrDefault(u => u.Логин == login.Text && u.Пароль == pass.Text && u.Должность == "Старший смены");
                if (cur != null)
                {
                    StarshWin starshWin = new StarshWin();
                    starshWin.Show();
                    Close();
                }
                else
                {
                    cur = AppDatas.db.Сотрудники.FirstOrDefault(u => u.Логин == login.Text && u.Пароль == pass.Text && u.Должность == "Администратор");
                    if (cur != null)
                    {
                        AdminWin adminWin = new AdminWin();
                        adminWin.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Данного пользователя нет в базе данных");
                    }
                }
            }
        }

        private void CheckBoxChecked(object sender, RoutedEventArgs e)
        {
            pass.Text = passBox.Password;
            passBox.Visibility = Visibility.Hidden;
        }

        private void CheckBoxUnchecked(object sender, RoutedEventArgs e)
        {
            passBox.Password = pass.Text;
            passBox.Visibility = Visibility.Visible;
        }
    }
}

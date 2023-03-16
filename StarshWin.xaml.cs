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

namespace Gorkogo
{
    /// <summary>
    /// Логика взаимодействия для StarshWin.xaml
    /// </summary>
    public partial class StarshWin : Window
    {
        int sec = 0;
        int min = 0;
        int hour = 0;
        System.Windows.Threading.DispatcherTimer Timer = new System.Windows.Threading.DispatcherTimer();
        public StarshWin()
        {
            InitializeComponent();
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
            Timer.Tick += TimerTick;
        }
        private void TimerTick(object sender, EventArgs e)
        {
            do
            {
                timer.Content = "Время сеанса: " + Convert.ToString(hour) + " ч " + Convert.ToString(min) + " м " + Convert.ToString(sec) + " с ";
                sec++;
                if (sec == 60)
                {
                    if (hour > -1 && min > 8)
                    {
                        MessageBox.Show("Время сеанца окончено");
                        Close();
                    }
                    if (hour == 0 && min == 4)
                    {
                        MessageBox.Show("До конца сеанса осталось 5 минут");
                    }
                    min++;
                    sec = 0;
                    if (min == 60)
                    {
                        hour++;
                        min = 0;
                    }
                }
            }
            while (sec <= 0);
        }
    }
}

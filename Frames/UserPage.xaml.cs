using Airlines_amonic.MainCSFiles;
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
using System.Windows.Threading;

namespace Airlines_amonic.Frames
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        private User user;
        DispatcherTimer reklama = new DispatcherTimer();
        public UserPage(User sended)
        {
            InitializeComponent();
            reklama.Interval = TimeSpan.FromSeconds(1);
            reklama.Tick += Reklama_Tick;
            reklama.Start();
            user = sended;
            Hello.Content = ("Hi " + user.FirstName + ", Welcome to AMONIC Airlines.");
        }
        int Seconds = 0;
        int Minute = 0;
        int Hour = 0;
        private void Reklama_Tick(object sender, EventArgs e)
        {
            Seconds += 1;
            if (Minute == 59 && Seconds == 60)
            {
                Hour++;
                Minute = 0;
                Seconds = 0;
            }
            if (Seconds == 60)
            {
                Minute++;
                Seconds = 0;
            }

            TimeInSystem.Text = ("Time spent on system: " + Convert.ToString(Hour) + ":" + Convert.ToString(Minute) + ":" + Convert.ToString(Seconds));

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}

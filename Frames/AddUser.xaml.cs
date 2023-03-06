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

namespace Airlines_amonic.Frames
{
    /// <summary>
    /// Логика взаимодействия для AddUser.xaml
    /// </summary>
    public partial class AddUser : Page
    {
        public AddUser()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            User NewUser = new User();
            string office = officeCB.SelectedValue.ToString();
            if (office == "System.Windows.Controls.ComboBoxItem: Abu Dhabi")
                NewUser.OfficeID = 1;
            else if (office == "System.Windows.Controls.ComboBoxItem: Cairo")
                NewUser.OfficeID = 3;
            else if (office == "System.Windows.Controls.ComboBoxItem: Bahrain")
                NewUser.OfficeID = 4;
            else if (office == "System.Windows.Controls.ComboBoxItem: Doha")
                NewUser.OfficeID = 5;
            else if (office == "System.Windows.Controls.ComboBoxItem: Riyadh")
                NewUser.OfficeID = 6;


            NewUser.RoleID = 1;
            NewUser.Email = EmailT.Text;
            NewUser.Password = PAT.Text;
            NewUser.FirstName = FNT.Text;
            NewUser.LastName = LNT.Text;
            NewUser.Birthdate = Convert.ToDateTime(BT.Text);
            NewUser.Active = true;
            new ConnectToDB().AddUser(NewUser);
            NavigationService.Navigate(new AdminPage());
        }
    }
}

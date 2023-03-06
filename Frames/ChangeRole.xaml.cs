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
    /// Логика взаимодействия для ChangeRole.xaml
    /// </summary>
    public partial class ChangeRole : Page
    {
        private User user;
        public ChangeRole(User sended)
        {
            InitializeComponent();
            user = sended;
            EmailT.Text = user.Email;
            FNT.Text = user.FirstName;
            LNT.Text = user.LastName;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminPage());
        }

        private User NewUser = new User();
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

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


            NewUser.ID = user.ID;
            NewUser.Email = EmailT.Text;
            NewUser.Password = user.Password;
            NewUser.FirstName = FNT.Text;
            NewUser.LastName = LNT.Text;
            NewUser.Birthdate = user.Birthdate;
            NewUser.Active = user.Active;
            new ConnectToDB().EditUser(NewUser);
            MessageBox.Show("Пользователь изменён");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            NewUser.RoleID = 2;
            RBA.IsChecked = false;
        }

        private void RBA_Checked(object sender, RoutedEventArgs e)
        {
            NewUser.RoleID = 1;
            RBU.IsChecked = false;
        }
    }
}

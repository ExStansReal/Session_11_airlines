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
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
            filldata();
        }

        private List<User> Users = new List<User>();
        public void filldata()
        {
            Users = new ConnectToDB().GetUser();
            MetricsDataGrid.ItemsSource = Users;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void officeCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string office = officeCB.SelectedValue.ToString();
            int OfficeID = 0;
            if (office == "System.Windows.Controls.ComboBoxItem: Abu Dhabi")
                OfficeID = 1;
            else if (office == "System.Windows.Controls.ComboBoxItem: Cairo")
                OfficeID = 2;
            else if (office == "System.Windows.Controls.ComboBoxItem: Bahrain")
                OfficeID = 3;
            else if (office == "System.Windows.Controls.ComboBoxItem: Doha")
                OfficeID = 4;
            else if (office == "System.Windows.Controls.ComboBoxItem: Riyadh")
                OfficeID = 5;
            List<User> useroffice = new ConnectToDB().GetUserWithOffice(OfficeID);
            MetricsDataGrid.ItemsSource = useroffice;
        }
        List<User> users = new List<User>();
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new AddUser());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            User user1 = new User();
            user1.ID = Users[MetricsDataGrid.SelectedIndex].ID;
            user1.RoleID = Users[MetricsDataGrid.SelectedIndex].RoleID;
            user1.Email = Users[MetricsDataGrid.SelectedIndex].Email;
            user1.Password = Users[MetricsDataGrid.SelectedIndex].Password;
            user1.FirstName = Users[MetricsDataGrid.SelectedIndex].FirstName;
            user1.LastName = Users[MetricsDataGrid.SelectedIndex].LastName;
            user1.OfficeID = Users[MetricsDataGrid.SelectedIndex].OfficeID;
            user1.Birthdate = Users[MetricsDataGrid.SelectedIndex].Birthdate;
            user1.Active = Users[MetricsDataGrid.SelectedIndex].Active;
            if (user1.Active == true)
                user1.Active = false;
            else if (user1.Active == false)
                user1.Active = true;
            new ConnectToDB().EditUser(user1);
            filldata();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            User user1 = new User();
            user1.ID = Users[MetricsDataGrid.SelectedIndex].ID;
            user1.RoleID = Users[MetricsDataGrid.SelectedIndex].RoleID;
            user1.Email = Users[MetricsDataGrid.SelectedIndex].Email;
            user1.Password = Users[MetricsDataGrid.SelectedIndex].Password;
            user1.FirstName = Users[MetricsDataGrid.SelectedIndex].FirstName;
            user1.LastName = Users[MetricsDataGrid.SelectedIndex].LastName;
            user1.OfficeID = Users[MetricsDataGrid.SelectedIndex].OfficeID;
            user1.Birthdate = Users[MetricsDataGrid.SelectedIndex].Birthdate;
            user1.Active = Users[MetricsDataGrid.SelectedIndex].Active;
            NavigationService.Navigate(new ChangeRole(user1));
        }
    }
}

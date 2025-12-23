using Checklist.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Checklist
{
    /// <summary>
    /// Interaction logic for UserControl2.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        public List<Person> People = new List<Person>{
            new Person{Name = "Lucas",Age =30, ID = 1234, Password = "test123"},
            new Person{Name = "Mark",Age =27, ID = 254 , Password = "test123"},
            new Person{Name = "Peter",Age =52, ID = 2145 , Password = "test123"},
            new Person{Name = "Luc",Age =32, ID = 235, Password = "test123" },
            new Person{Name = "Kaat",Age =10, ID = 42, Password = "test123" }

            };
        public Login()
        {
            InitializeComponent();
            this.DataContext = People;
            Names.ItemsSource = People;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string PW = Pasword.Password;
            if (PW != "" && Names.SelectedItem != null)
            {
                Person person = (Person)Names.SelectedItem;
                if (PW == person.Password)
                {
                    MessageBox.Show("Logging in: " + person.Name + "\n ID: " + person.ID);
                    Window window = Window.GetWindow(this);
                    window.Content = new ChecklistOverview();
                }
                else
                {
                    ErrorLabel.Content = "The password doenst match";
                }
            }
            else
            {
                ErrorLabel.Content = "Please select a person and fill in the pasword";
            }

        }

        private void OnPasswordChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Pasword.Password))
            {
                LoginBttn.IsEnabled = true;
            }
        }
    }
}

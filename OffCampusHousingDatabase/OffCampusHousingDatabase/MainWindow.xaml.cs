using System;
using System.Collections;
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
using System.Configuration;

namespace OffCampusHousingDatabase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool loggedOn;
        String email;
        DatabaseHelper dbHelper;

        public MainWindow()
        {
            InitializeComponent();
            loggedOn = false;
            email = "";

            dbHelper = new DatabaseHelper(ConfigurationManager.ConnectionStrings["MySQLDB"].ConnectionString);

            loadAllProperties();
        }

        public MainWindow(String email)
        {
            InitializeComponent();
            loggedOn = true;
            this.email = email;

            dbHelper = new DatabaseHelper(ConfigurationManager.ConnectionStrings["MySQLDB"].ConnectionString);

            //Show on the UI that the user is logged on, and hide the Login, Or, and Signup textblocks
            LoginTextblock.Text = email;
            OrTextblock.Text = "";
            SignupTextblock.Text = "";

            loadAllProperties();

        }

        private void login_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Login l = new Login();
            App.Current.MainWindow = l;
            this.Close();
            l.Show();
        }

        private void login_MouseEnter(object sender, MouseEventArgs e)
        {
            LoginTextblock.TextDecorations = TextDecorations.Underline;
        }

        private void login_MouseLeave(object sender, MouseEventArgs e)
        {
            LoginTextblock.TextDecorations = null;
        }

        private void signup_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SignUp sign = new SignUp();
            App.Current.MainWindow = sign;
            this.Close();
            sign.Show();
        }

        private void signup_MouseEnter(object sender, MouseEventArgs e)
        {
            SignupTextblock.TextDecorations = TextDecorations.Underline;
        }

        private void signup_MouseLeave(object sender, MouseEventArgs e)
        {
            SignupTextblock.TextDecorations = null;
        }

        private void Property_Click(object sender, MouseButtonEventArgs e)
        {
            if (PropertyListView.SelectedIndex < 0)
                return;

            PropertyItem n = (PropertyItem)PropertyListView.SelectedItem;

            PropertyDescription pd = new PropertyDescription(n.PropID);
            App.Current.MainWindow = pd;
            this.Close();
            pd.Show();
        }

        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            loadFilteredProperties();
        }


        private void loadAllProperties()
        {
            PropertyListView.Items.Clear();

            ArrayList rows = dbHelper.DatabaseSelect("Property");

            foreach (String[] row in rows)
            {
                PropertyListView.Items.Add(new PropertyItem { PropID = Convert.ToInt32(row[0]), Addr = row[1], Rent = Convert.ToInt32(row[4]), RealData = Convert.ToInt32(row[5]) });
            }

        }

        private void loadFilteredProperties()
        {
            PropertyListView.Items.Clear();

            ArrayList rows = dbHelper.DatabaseSelect("Property", "`MonthlyRent` < '" + FilterRentTextbox.Text + "'");

            foreach (String[] row in rows)
            {
                PropertyListView.Items.Add(new PropertyItem { PropID = Convert.ToInt32(row[0]), Addr = row[1], Rent = Convert.ToInt32(row[4]), RealData = Convert.ToInt32(row[5]) });
            }

        }


        private class PropertyItem
        {
            public int PropID { get; set; }
            public string Addr { get; set; }
            public int Rent { get; set; }
            public int RealData { get; set; }
        }

        
    }
}

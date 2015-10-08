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

namespace OffCampusHousingDatabase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool loggedOn;
        String email;

        public MainWindow()
        {
            InitializeComponent();
            loggedOn = false;
            email = "";
        }

        public MainWindow(String email)
        {
            InitializeComponent();
            loggedOn = true;
            this.email = email;

            //Show on the UI that the user is logged on, and hide the Login, Or, and Signup textblocks
            LoginTextblock.Text = email;
            OrTextblock.Text = "";
            SignupTextblock.Text = "";

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
    }
}

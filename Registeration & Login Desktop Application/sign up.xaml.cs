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

namespace Registeration___Login_Desktop_Application
{
    /// <summary>
    /// Interaction logic for sign_up.xaml
    /// </summary>
    public partial class sign_up : Page
    {
        projectoEntities db = new projectoEntities();
        public sign_up()
        {
            InitializeComponent();
        }

        private void login2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sing_upp_Click(object sender, RoutedEventArgs e)
        {
            USERR s = new USERR("  ^ (?=.*[a-z])   (?=.*[A-Z])  (?=.*\\d)   (?=.*!@#$%^&*()_-=+).{8,15}  $  ");
            if (s.IsMatch(us.text))
            {
                USERR user = new USERR();
                user.USERRNAME = us;
                user.PASSWORDD = pas;
                user.GENDER = gend;
                user.AGE = ag;
                db.USERRs.Add(user);


                db.SaveChanges();
                MessageBox.Show("Signup successfully");
            }
            else
            {

                MessageBox.Show("It must contain at least one lowercase letter.\r\nIt must contain at least one uppercase letter.\r\nIt must contain at least one digit.\r\nIt must be between 8 and 15 characters long.");

            }
        }
    }
}

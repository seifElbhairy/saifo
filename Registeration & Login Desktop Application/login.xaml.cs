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
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
        projectoEntities db = new projectoEntities();
        public login()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            USERR cd = db.USERRs.FirstOrDefault(x => x.USERRNAME == ut.text && x.PASSWORDD == pas.Text);
            if (cd == null)
            {
                MessageBox.Show("invalid");
            }
            else if (cd.USERRNAME == ut.text && cd.PASSWORDD == ut.text)
            {
                USERR mm = new USERR();
                this.NavigationService.Navigate(cd);
                MessageBox.Show("valid");
            }
        }

        private void forget_Click(object sender, RoutedEventArgs e)
        {
            USERR cd = db.USERRs.FirstOrDefault(x => x.USERRNAME == ut.text && x.PASSWORDD == pas.Text);
            if (cd == null)
            {
                MessageBox.Show("invalid");
            }
            else if (cd.USERRNAME == ut.text && cd.PASSWORDD == ut.text)
            {
                USERR mm = new USERR();
                this.NavigationService.Navigate(cd);
                MessageBox.Show("valid");
            }
        }
    }
}
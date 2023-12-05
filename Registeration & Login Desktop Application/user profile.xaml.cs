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
    /// Interaction logic for user_profile.xaml
    /// </summary>
    public partial class user_profile : Page
    {
        projectoEntities db = new projectoEntities();
        public user_profile()
        {
            InitializeComponent();
        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dg.ItemsSource = db.USERR.Where(x => x.namm == namm.Text).ToList()
              this.NavigationService.Navigate(s2);
        }
    }
}

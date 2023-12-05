using System;
using System.Collections;
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
    /// Interaction logic for search.xaml
    /// </summary>
    public partial class search : Page
    {
        projectoEntities db = new projectoEntities();
        public search() 
        {
            InitializeComponent();
        }

        private void sear_Click(object sender, RoutedEventArgs e)
        {
            db.ItemSource.Adminns(db.ADMINEs.Where(x => x.ADMINN_NAME == txt.Text).ToList();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dg.ItemsSource = db.ADMINEs.Where(x => x.ADMINN_NAME == txt.Text).ToList();
            this.NavigationService.Navigate(s);
            dg.ItemsSource = db.ADMINEs.ToList();
        }
    }
}

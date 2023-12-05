using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
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
using System.Xml.Linq;

namespace Registeration___Login_Desktop_Application
{
    /// <summary>
    /// Interaction logic for delete.xaml
    /// </summary>
    public partial class delete : Page
    {
        projectoEntities db = new projectoEntities();
        public delete()
        {
            InitializeComponent();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
           
           db.ADMINEs.Remove(db.ADMINEs.First(x => x.ADMINN_NAME == tx.Text));
            db.SaveChanges();
            MessageBox.Show("removedd");
        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dg.ItemsSource = db.ADMINEs.Where(x => x.ADMINN_NAME == tx.Text).ToList();
              this.NavigationService.Navigate(d);
            dg.ItemsSource= db.ADMINEs.ToList();
        }
    }
}

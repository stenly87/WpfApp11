using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp11
{
    /// <summary>
    /// Interaction logic for ListHumanPage.xaml
    /// </summary>
    public partial class ListHumanPage : Page
    {
        public ListHumanPage()
        {
            InitializeComponent();
            DataContext = new ListHumanViewModel();
        }
    }
}

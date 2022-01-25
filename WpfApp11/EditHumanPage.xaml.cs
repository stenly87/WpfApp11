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

namespace WpfApp11
{
    /// <summary>
    /// Interaction logic for EditHumanPage.xaml
    /// </summary>
    public partial class EditHumanPage : Page
    {
        Human human;
        public EditHumanPage()
        {
            InitializeComponent();
            human = new Human();
            DataContext = human;
        }
        public EditHumanPage(Human selectedHuman)
        {
            InitializeComponent();
            human = selectedHuman;
            DataContext = human;
        }

        private void AddHuman(object sender, RoutedEventArgs e)
        {
            if (!Data.Humans.Contains(human))
                Data.Humans.Add(human);
            human = new Human();
            DataContext = human;
        }

        private void ListHuman(object sender, RoutedEventArgs e)
        {
            Data.CurrentPage = new ListHumanPage();
        }
    }
}

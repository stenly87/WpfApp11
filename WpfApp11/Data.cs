using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp11
{
    class Data
    {
        public static ObservableCollection<Human> Humans = new ObservableCollection<Human>();
        private static Page currentPage;
        public static event EventHandler CurrentPageChanged;
        public static Page CurrentPage
        {
            get => currentPage;
            internal set
            {
                currentPage = value;
                CurrentPageChanged?.Invoke(CurrentPage, new EventArgs());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11
{
    public class EditHumanViewModel : INotifyPropertyChanged
    {
        private Human human;

        public Human Human
        {
            get => human;
            set
            {
                human = value;
                Signal();
            }
        }
        public CustomCommand AddHuman { get; set; }
        public CustomCommand ListHuman { get; set; }

        public EditHumanViewModel(Human human)
        {
            Human = human;
            AddHuman = new CustomCommand(() =>
            {
                if (!Data.Humans.Contains(Human))
                    Data.Humans.Add(Human);
                Human = new Human();
            }, () => true);

            ListHuman = new CustomCommand(() =>
            {
                Data.CurrentPage = new ListHumanPage();
            }, () => true);
        }

        public EditHumanViewModel() : this(new Human())
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void Signal([CallerMemberName] string prop = null) =>
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(prop));
    }
}

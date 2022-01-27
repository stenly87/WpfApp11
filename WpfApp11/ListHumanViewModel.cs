using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11
{
    public class ListHumanViewModel : INotifyPropertyChanged
    {
        private Human selectedHuman;

        public CustomCommandTarget RemoveHuman { get; set; }
        //public CustomCommand RemoveHuman { get; set; }
        public CustomCommand EditHuman { get; set; }
        public Human SelectedHuman
        {
            get => selectedHuman;
            set
            {
                selectedHuman = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedHuman"));
            }
        }
        public ObservableCollection<Human> Humans => Data.Humans;

        public ListHumanViewModel()
        {
            /*RemoveHuman = new CustomCommand(
                () => {
                    Humans.Remove(SelectedHuman);
                }, () => SelectedHuman != null);*/
            RemoveHuman = new CustomCommandTarget((human) =>
            {
                var removing = (Human)human;
                Humans.Remove(removing);
            });
            EditHuman = new CustomCommand(
                () =>
                {
                    Data.CurrentPage = new EditHumanPage(SelectedHuman);
                }, () => SelectedHuman != null);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

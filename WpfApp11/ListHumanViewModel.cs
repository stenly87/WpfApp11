using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11
{
    public class ListHumanViewModel
    {
        public CustomCommand RemoveHuman { get; set; }
        public CustomCommand EditHuman { get; set; }
        public Human SelectedHuman { get; set; }
        public ObservableCollection<Human> Humans => Data.Humans;

        public ListHumanViewModel()
        {
            RemoveHuman = new CustomCommand(
                () => {
                    Humans.Remove(SelectedHuman);
                }, () => SelectedHuman != null);
            EditHuman = new CustomCommand(
                () => {
                    Data.CurrentPage = new EditHumanPage(SelectedHuman);
                }, () => SelectedHuman != null);
        }
    }
}

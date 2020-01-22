using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace ExpandableListView.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private MvxObservableCollection<ItemViewModel> items;
        public MvxObservableCollection<ItemViewModel> Items
        {
            get { return items; }
            set
            {
                items = value;
                RaisePropertyChanged(() => Items);
            }
        }

        private IMvxCommand selectItemChildCommand;
        public IMvxCommand SelectItemChildCommand
        {
            get
            {
                if (selectItemChildCommand == null)
                    selectItemChildCommand = new MvxCommand<ItemChildViewModel>(async (itemChild) => await SelectItemChild(itemChild));

                return selectItemChildCommand;
            }
        }

        private IMvxCommand selectItemCommand;
        public IMvxCommand SelectItemCommand
        {
            get
            {
                if (selectItemCommand == null)
                    selectItemCommand = new MvxCommand<ItemViewModel>(async (item) => await SelectItem(item));

                return selectItemCommand;
            }
        }

        private async Task SelectItemChild(ItemChildViewModel itemChild)
        {

        }

        private async Task SelectItem(ItemViewModel item)
        {
            Items.Remove(item);
        }

        public MainViewModel()
        {
            Items = new MvxObservableCollection<ItemViewModel>();
            for (int i = 0; i < 1; i++)
            {
                Items.Add(new ItemViewModel($"Title {i}"));
            }
        }
    }
}
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace ExpandableListView.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public bool ShouldExpandGroup { get; set; }

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

        private IMvxCommand<int> selectItemCommand;
        public IMvxCommand<int> SelectItemCommand
        {
            get
            {
                if (selectItemCommand == null)
                    selectItemCommand = new MvxCommand<int>((item) => SelectItem(item));

                return selectItemCommand;
            }
        }

        private async Task SelectItemChild(ItemChildViewModel itemChild)
        {

        }

        private void SelectItem(int itemPosition)
        {
            ShouldExpandGroup = false;
            if (itemPosition + 1 == Items.Count)
            {
                Items.RemoveAt(itemPosition);
                ShouldExpandGroup = true;
            }
        }

        public MainViewModel()
        {
            Items = new MvxObservableCollection<ItemViewModel>();
            for (int i = 0; i < 11; i++)
            {
                Items.Add(new ItemViewModel($"Title {i}"));
            }
        }
    }
}
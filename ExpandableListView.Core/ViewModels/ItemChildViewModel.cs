using MvvmCross.ViewModels;

namespace ExpandableListView.Core.ViewModels
{
    public class ItemChildViewModel : MvxViewModel
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; RaisePropertyChanged(() => Title); }
        }

        public ItemChildViewModel(string title)
        {
            Title = title;
        }
    }
}
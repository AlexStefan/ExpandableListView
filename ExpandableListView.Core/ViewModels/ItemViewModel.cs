using System.ComponentModel;
using System.Runtime.CompilerServices;
using MvvmCross.ViewModels;

namespace ExpandableListView.Core.ViewModels
{
    public class ItemViewModel : MvxObservableCollection<ItemChildViewModel>, INotifyPropertyChanged
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; OnPropertyChanged("Title"); }
        }

        public ItemViewModel(string title)
        {
            Title = title;
            for (int i = 0; i < 7; i++)
            {
                base.Add(new ItemChildViewModel($"Child title {i}"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
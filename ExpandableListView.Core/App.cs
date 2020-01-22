using ExpandableListView.Core.ViewModels;
using MvvmCross.ViewModels;

namespace ExpandableListView.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<MainViewModel>();
        }
    }
}
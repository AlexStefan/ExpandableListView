using System;
using Android.App;
using Android.Runtime;
using ExpandableListView.Core;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace ExpandableListView
{
    [Application]
    public class MainApplication : MvxAppCompatApplication<MvxAppCompatSetup<App>, App>
    {
        public MainApplication()
        {
        }

        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }
    }
}
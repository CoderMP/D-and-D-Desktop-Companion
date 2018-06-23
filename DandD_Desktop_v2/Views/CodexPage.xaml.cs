using DandD_Desktop_v2.Views.CodexInfoPages;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace DandD_Desktop_v2.Views
{
    public sealed partial class CodexPage : Page, INotifyPropertyChanged
    {
        public CodexPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SystemNavigationManager navMgr = SystemNavigationManager.GetForCurrentView();
            navMgr.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void OnClassButtonClicked(object sender, RoutedEventArgs e)
        {
            if (sender == _btnBarbarianClass)
            {
                this.Frame.Navigate(typeof(BarbarianCodexPage));
            }
        }
    }
}

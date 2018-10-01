using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DandD_Desktop_v2.Views.CodexInfoPages
{
    public sealed partial class BardCodexPage : Page
    {
        public BardCodexPage()
        {
            this.InitializeComponent();

            SystemNavigationManager navMgr = SystemNavigationManager.GetForCurrentView();
            navMgr.BackRequested += OnNavigateBack;
        }

        private void OnNavigateBack(object sender, BackRequestedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.Navigate(typeof(CodexPage));
                e.Handled = true;
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SystemNavigationManager navMgr = SystemNavigationManager.GetForCurrentView();
            navMgr.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
        }
    }
}

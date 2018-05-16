using System;

using DandD_Desktop_v2.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace DandD_Desktop_v2.Views
{
    public sealed partial class DMConsoleDetailControl : UserControl
    {
        public SampleOrder MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as SampleOrder; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(SampleOrder), typeof(DMConsoleDetailControl), new PropertyMetadata(null, OnMasterMenuItemPropertyChanged));

        public DMConsoleDetailControl()
        {
            InitializeComponent();
        }

        private static void OnMasterMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as DMConsoleDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}

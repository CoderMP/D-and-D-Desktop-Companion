using DandD_Desktop_v2.Views.CodexInfoPages;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

namespace DandD_Desktop_v2.Views
{
    public sealed partial class CodexPage : Page, INotifyPropertyChanged
    {
        /// <summary>
        /// Private field variables for the race sprites
        /// </summary>
        #region Private Field Variables
        private static readonly BitmapImage AARAKOCRA;
        private static readonly BitmapImage AASIMER;
        private static readonly BitmapImage BUGBEAR;
        private static readonly BitmapImage DRAGONBORN;
        private static readonly BitmapImage DWARF;
        private static readonly BitmapImage ELF;
        private static readonly BitmapImage FERALTIEFLING;
        private static readonly BitmapImage FIRBOLG;
        private static readonly BitmapImage GENASI;
        private static readonly BitmapImage GNOME;
        private static readonly BitmapImage GOBLIN;
        private static readonly BitmapImage GOLIATH;
        private static readonly BitmapImage HALFELF;
        private static readonly BitmapImage HALFLING;
        private static readonly BitmapImage HALFORC;
        private static readonly BitmapImage HOBGOBLIN;
        private static readonly BitmapImage HUMAN;
        private static readonly BitmapImage KENKU;
        private static readonly BitmapImage KOBOLD;
        private static readonly BitmapImage LIZARDFOLK;
        private static readonly BitmapImage ORC;
        private static readonly BitmapImage TABAXI;
        private static readonly BitmapImage TIEFLING;
        private static readonly BitmapImage TORTLE;
        private static readonly BitmapImage TRITON;
        private static readonly BitmapImage YUTIPUREBLOOD;
        #endregion

        /// <summary>
        /// Constructor method for the CodexPage
        /// </summary>
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

        #region Event Handler Methods
        /// <summary>
        /// Event Handler method for the Class tab of the CodexPage
        /// </summary>
        /// <param name="sender">The ListViewItem that was clicked/selected</param>
        /// <param name="e">Default event argument</param>
        private void OnClassButtonClicked(object sender, RoutedEventArgs e)
        {
            if (sender == _btnBarbarianClass)
            {
                this.Frame.Navigate(typeof(BarbarianCodexPage));
            }
            if (sender == _btnBardClass)
            {
                this.Frame.Navigate(typeof(BardCodexPage));
            }
            if (sender == _btnClericClass)
            {
                this.Frame.Navigate(typeof(ClericCodexPage));
            }
            if (sender == _btnDruidClass)
            {
                this.Frame.Navigate(typeof(DruidCodexPage));
            }
            if (sender == _btnFighterClass)
            {
                this.Frame.Navigate(typeof(FighterCodexPage));
            }
            if (sender == _btnMonkClass)
            {
                this.Frame.Navigate(typeof(MonkCodexPage));
            }
            if (sender == _btnPaladinClass)
            {
                this.Frame.Navigate(typeof(PaladinCodexPage));
            }
            if (sender == _btnRangerClass)
            {
                this.Frame.Navigate(typeof(RangerCodexPage));
            }
            if (sender == _btnRogueClass)
            {
                this.Frame.Navigate(typeof(RogueCodexPage));
            }
            if (sender == _btnSorcererClass)
            {
                this.Frame.Navigate(typeof(SorcererCodexPage));
            }
            if (sender == _btnWarlockClass)
            {
                this.Frame.Navigate(typeof(WarlockCodexPage));
            }
            if (sender == _btnWizardClass)
            {
                this.Frame.Navigate(typeof(WizardCodexPage));
            }
        }

        /// <summary>
        /// Event handler method for the Player Races tab of the CodexPage
        /// </summary>
        /// <param name="sender">The ListViewItem that was selected/clicked</param>
        /// <param name="e">Default event argument</param>
        private void OnRaceListItemClick(object sender, ItemClickEventArgs e)
        {
            if (sender == _lstAarakocra)
            {

            }
            if (sender == _lstAasimer)
            {

            }
            if (sender == _lstBugbear)
            {

            }
            if (sender == _lstDragonborn)
            {

            }
            if (sender == _lstDwarf)
            {

            }
            if (sender == _lstElf)
            {

            }
            if (sender == _lstFeralTiefling)
            {

            }
            if (sender == _lstFirbolg)
            {

            }
            if (sender == _lstGenasi)
            {

            }
            if (sender == _lstGnaome)
            {

            }
            if (sender == _lstGoblin)
            {

            }
            if (sender == _lstGoliath)
            {

            }
            if (sender == _lstHalfElf)
            {

            }
            if (sender == _lstHalfling)
            {

            }
            if (sender == _lstHalfOrc)
            {

            }
            if (sender == _lstHobgoblin)
            {

            }
            if (sender == _lstHuman)
            {

            }
            if (sender == _lstKenku)
            {

            }
            if (sender == _lstKobold)
            {

            }
            if (sender == _lstLizardFolk)
            {

            }
            if (sender == _lstOrc)
            {

            }
            if (sender == _lstTabaxi)
            {

            }
            if (sender == _lstTiefling)
            {

            }
            if (sender == _lstTortle)
            {

            }
            if (sender == _lstTriton)
            {

            }
            if (sender == _lstYuTiPureblood)
            {

            }
        }

        /// <summary>
        /// Event handler method for the Magic Schools tab of the CodexPage
        /// </summary>
        /// <param name="sender">The Button that wa clicked/selected</param>
        /// <param name="e">Default event argument</param>
        private void OnMagicSchoolButtonClicked(object sender, RoutedEventArgs e)
        {
            if (sender == _btnAbjuration) { /*TODO: Navigate*/ }
            if (sender == _btnConjuration) { /*TODO: Navigate*/ }
            if (sender == _btnDivination) { /*TODO: Navigate*/ }
            if (sender == _btnEnchantment) { /*TODO: Navigate*/ }
            if (sender == _btnEvocation) { /*TODO: Navigate*/ }
            if (sender == _btnIllusion) { /*TODO: Navigate*/ }
            if (sender == _btnNecromancy) { /*TODO: Navigate*/ }
            if (sender == _btnTransmutation) { /*TODO: Navigate*/ }
        }
        #endregion
    }
}

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace DandD_Desktop_v2.Views
{
    public sealed partial class InventoryPage : Page, INotifyPropertyChanged
    {
        public InventoryPage()
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

        /// <summary>
        /// Event handler method for when the decrementer button for the ammo/resources/charges
        /// is clicked.
        /// </summary>
        /// <param name="sender"> The clicked decrementer button</param>
        /// <param name="e"></param>
        private void OnAmmoDecrementerClicked(object sender, RoutedEventArgs e)
        {
            //Check to see which decrementer button was clicked
            if (sender == _btnAmmo1Decrementer)
            {
                //Retrieve the current ammo amount by parsing the contents of the TextBlock
                int ammoTotal = int.Parse(_txtAmmo1Count.Text);

                //Decrement the total value so long as it's greater than zero
                if (ammoTotal > 0)
                {
                    ammoTotal--;
                }

                //Update the ammo count label
                _txtAmmo1Count.Text = ammoTotal.ToString();
            }

            else if (sender == _btnAmmo2Decrementer)
            {
                //Retrieve the current ammo amount by parsing the contents of the TextBlock
                int ammoTotal = int.Parse(_txtAmmo2Count.Text);

                //Decrement the total value so long as it's greater than zero
                if (ammoTotal > 0)
                {
                    ammoTotal--;
                }

                //Update the ammo count label
                _txtAmmo2Count.Text = ammoTotal.ToString();
            }

            else if (sender == _btnAmmo3Decrementer)
            {
                //Retrieve the current ammo amount by parsing the contents of the TextBlock
                int ammoTotal = int.Parse(_txtAmmo3Count.Text);

                //Decrement the total value so long as it's greater than zero
                if (ammoTotal > 0)
                {
                    ammoTotal--;
                }

                //Update the ammo count label
                _txtAmmo3Count.Text = ammoTotal.ToString();
            }

            else if (sender == _btnAmmo4Decrementer)
            {
                //Retrieve the current ammo amount by parsing the contents of the TextBlock
                int ammoTotal = int.Parse(_txtAmmo4Count.Text);

                //Decrement the total value so long as it's greater than zero
                if (ammoTotal > 0)
                {
                    ammoTotal--;
                }

                //Update the ammo count label
                _txtAmmo4Count.Text = ammoTotal.ToString();
            }

            else if (sender == _btnAmmo5Decrementer)
            {
                //Retrieve the current ammo amount by parsing the contents of the TextBlock
                int ammoTotal = int.Parse(_txtAmmo5Count.Text);

                //Decrement the total value so long as it's greater than zero
                if (ammoTotal > 0)
                {
                    ammoTotal--;
                }

                //Update the ammo count label
                _txtAmmo5Count.Text = ammoTotal.ToString();
            }

            else if (sender == _btnAmmo6Decrementer)
            {
                //Retrieve the current ammo amount by parsing the contents of the TextBlock
                int ammoTotal = int.Parse(_txtAmmo6Count.Text);

                //Decrement the total value so long as it's greater than zero
                if (ammoTotal > 0)
                {
                    ammoTotal--;
                }

                //Update the ammo count label
                _txtAmmo6Count.Text = ammoTotal.ToString();
            }
        }

        /// <summary>
        /// Event handler method for when the incrementer buttons for the ammo/resource/charges is clicked.
        /// </summary>
        /// <param name="sender"> The incrementer button that was clicked </param>
        /// <param name="e"></param>
        private void OnAmmoIncrementerClicked(object sender, RoutedEventArgs e)
        {
            //Check to see which decrementer button was clicked
            if (sender == _btnAmmo1Incrementer)
            {
                //Retrieve the current ammo amount by parsing the contents of the TextBlock
                int ammoTotal = int.Parse(_txtAmmo1Count.Text);

                //Increment the total value
                ammoTotal += 1;

                //Update the ammo count label
                _txtAmmo1Count.Text = ammoTotal.ToString();
            }

            else if (sender == _btnAmmo2Incrementer)
            {
                //Retrieve the current ammo amount by parsing the contents of the TextBlock
                int ammoTotal = int.Parse(_txtAmmo2Count.Text);

                //Increment the total value
                ammoTotal += 1;

                //Update the ammo count label
                _txtAmmo2Count.Text = ammoTotal.ToString();
            }

            else if (sender == _btnAmmo3Incrementer)
            {
                //Retrieve the current ammo amount by parsing the contents of the TextBlock
                int ammoTotal = int.Parse(_txtAmmo3Count.Text);

                //Increment the total value
                ammoTotal += 1;

                //Update the ammo count label
                _txtAmmo3Count.Text = ammoTotal.ToString();
            }

            else if (sender == _btnAmmo4Incrementer)
            {
                //Retrieve the current ammo amount by parsing the contents of the TextBlock
                int ammoTotal = int.Parse(_txtAmmo4Count.Text);

                //Increment the total value
                ammoTotal += 1;

                //Update the ammo count label
                _txtAmmo4Count.Text = ammoTotal.ToString();
            }

            else if (sender == _btnAmmo5Incrementer)
            {
                //Retrieve the current ammo amount by parsing the contents of the TextBlock
                int ammoTotal = int.Parse(_txtAmmo5Count.Text);

                //Increment the total value
                ammoTotal += 1;

                //Update the ammo count label
                _txtAmmo5Count.Text = ammoTotal.ToString();
            }

            else if (sender == _btnAmmo6Incrementer)
            {
                //Retrieve the current ammo amount by parsing the contents of the TextBlock
                int ammoTotal = int.Parse(_txtAmmo6Count.Text);

                //Increment the total value
                ammoTotal += 1;

                //Update the ammo count label
                _txtAmmo6Count.Text = ammoTotal.ToString();
            }
        }

        /// <summary>
        /// Event handler method for when the decrementer buttons for the currency is clicked.
        /// </summary>
        /// <param name="sender">The decrementer button that was clicked</param>
        /// <param name="e"></param>
        private void OnCurrencyDecrementerClicked(object sender, RoutedEventArgs e)
        {
            if (sender == _btnCopperDecrementer)
            {
                //Retrieve the total current copper amount
                int copperTotal = int.Parse(_txtCopperCount.Text);

                //Decrement the total copper amount
                if (copperTotal > 0)
                {
                    copperTotal -= 1;
                }

                //Update the copper amount label
                _txtCopperCount.Text = copperTotal.ToString();
            }

            else if (sender == _btnSilverDecrementer)
            {
                //Retrieve the total current silver amount
                int silverTotal = int.Parse(_txtSilverCount.Text);

                //Decrement the total silver amount
                if (silverTotal > 0)
                {
                    silverTotal -= 1;
                }

                //Update the copper silver label
                _txtSilverCount.Text = silverTotal.ToString();
            }

            else if (sender == _btnGoldDecrementer)
            {
                //Retrieve the total current copper amount
                int goldTotal = int.Parse(_txtGoldCount.Text);

                //Decrement the total copper amount
                if (goldTotal > 0)
                {
                    goldTotal -= 1;
                }

                //Update the copper amount label
                _txtGoldCount.Text = goldTotal.ToString();
            }

            else if (sender == _btnPlatinumDecrementer)
            {
                //Retrieve the total current copper amount
                int platinumTotal = int.Parse(_txtPlatinumCount.Text);

                //Decrement the total copper amount
                if (platinumTotal > 0)
                {
                    platinumTotal -= 1;
                }

                //Update the copper amount label
                _txtCopperCount.Text = platinumTotal.ToString();
            }
        }

        /// <summary>
        /// Event handler method for when one of the currency incrementer buttons is clicked.
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e"></param>
        private void OnCurrencyIncrementerClicked(object sender, RoutedEventArgs e)
        {
            if (sender == _btnCopperIncrementer)
            {
                //Retrieve the total current copper amount
                int copperTotal = int.Parse(_txtCopperCount.Text);

                //Increment the total copper amount
                copperTotal += 1;

                //Update the copper amount label
                _txtCopperCount.Text = copperTotal.ToString();
            }

            else if (sender == _btnSilverIncrementer)
            {
                //Retrieve the total current silver amount
                int silverTotal = int.Parse(_txtSilverCount.Text);

                //Increment the total silver amount
                silverTotal += 1;

                //Update the silver amount label
                _txtSilverCount.Text = silverTotal.ToString();
            }

            else if (sender == _btnGoldIncrementer)
            {
                //Retrieve the total current gold amount
                int goldTotal = int.Parse(_txtGoldCount.Text);

                //Increment the total gold amount
                goldTotal += 1;

                //Update the gold amount label
                _txtGoldCount.Text = goldTotal.ToString();
            }

            else if (sender == _btnPlatinumIncrementer)
            {
                //Retrieve the total current platinum amount
                int platinumTotal = int.Parse(_txtPlatinumCount.Text);

                //Increment the total platinum amount
                platinumTotal += 1;

                //Update the platinum amount label
                _txtPlatinumCount.Text = platinumTotal.ToString();
            }
        }
    }
}

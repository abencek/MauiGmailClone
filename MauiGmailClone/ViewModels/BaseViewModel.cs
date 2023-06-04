using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiGmailClone.ViewModels
{
    /// <summary>
    /// A base View Model
    /// </summary>
    public partial class BaseViewModel : ObservableObject
    {

        #region Private Members

        /// <summary>
        /// True indicates running command
        /// </summary>
        [ObservableProperty]
        bool isRunning;

        /// <summary>
        /// True indicates opened Flyout
        /// </summary>
        [ObservableProperty]
        private bool isFlyoutOpen = true;

        #endregion

        #region Commands

        /// <summary>
        /// Opens Flyout menu
        /// </summary>
        [RelayCommand]
        private void OpenFlyout()
        {
            IsFlyoutOpen = true;
        }


        /// <summary>
        /// Returns to previous page
        /// </summary>
        /// <returns>Instance of <see cref="Task"/></returns>
        [RelayCommand]
        async Task GoToPreviousPage()
        {
            await Shell.Current.GoToAsync("..");
        }

        #endregion
    }
}

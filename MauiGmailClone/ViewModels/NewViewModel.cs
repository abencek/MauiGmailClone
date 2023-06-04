using CommunityToolkit.Mvvm.Input;

namespace MauiGmailClone.ViewModels
{
    /// <summary>
    /// A View Model for New page
    /// </summary>
    public partial class NewViewModel : BaseViewModel
    {
        #region Commands

        /// <summary>
        /// Sends new email 
        /// </summary>
        /// <returns>Instance of <see cref="Task"/></returns>
        [RelayCommand]
        private async Task SendEmail()
        {
            //In this demo app it navigates to previous page only
            await Shell.Current.GoToAsync("..");
        }

        #endregion

    }
}

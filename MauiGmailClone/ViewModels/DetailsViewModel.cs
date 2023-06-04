using CommunityToolkit.Mvvm.ComponentModel;
using MauiGmailClone.Models;

namespace MauiGmailClone.ViewModels
{
    /// <summary>
    /// A View Model for Details page
    /// </summary>
    [QueryProperty(nameof(Email),"Email")]
    public partial class DetailsViewModel : BaseViewModel
    {
        #region Private Members

        /// <summary>
        /// Current email (value is received from query parameter)
        /// </summary>
        [ObservableProperty]
        private ReceivedEmail email;

        #endregion
    }
}

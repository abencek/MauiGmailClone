using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using MauiGmailClone.Models;
using MauiGmailClone.Services;
using MauiGmailClone.Views;

namespace MauiGmailClone.ViewModels
{
    /// <summary>
    /// A View Model for Main page
    /// </summary>
    public partial class MainViewModel : BaseViewModel
    {

        #region Private Members

        /// <summary>
        /// Service that provides access to the user's emails
        /// </summary>
        private readonly EmailService _emailService;

        #endregion

        #region Observable Properties

        /// <summary>
        /// Name of a group to which current <see cref="Emails"/> belongs to/>
        /// </summary>
        [ObservableProperty]
        private string emailGroup;

        #endregion

        #region Public Properties

        /// <summary>
        /// List of the user's emails
        /// </summary>
        public ObservableCollection<ReceivedEmail> Emails { get; } = new();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="emailService"></param>
        public MainViewModel(EmailService emailService)
        {
            _emailService = emailService;
        }

        #endregion

        #region Commands

        /// <summary>
        /// Gets new emails and updates list of <see cref="Emails"/>
        /// </summary>
        /// <returns>Instance of <see cref="Task"/></returns>
        [RelayCommand]
        public async Task GetEmailsAsync(string groupName)
        {
            IsFlyoutOpen = false;

            if (IsRunning)
                return;

            try
            {
                IsRunning = true;

                var emails = await _emailService.GetEmails();

                Emails.Clear();
                foreach (var email in emails)
                    Emails.Add(email);

                EmailGroup = groupName;
            }
            catch (Exception)
            {
                throw new FileNotFoundException("Cannot load emails from a file!");
            }
            finally
            {
                IsRunning = false;
                //Ensure that Mail tab is active
                await GoToPage("///tabmail");
            }

        }


        /// <summary>
        /// Opens Details page for selected email
        /// </summary>
        /// <param name="email">Selected email</param>
        /// <returns>Instance of <see cref="Task"/></returns>
        [RelayCommand]
        private async Task GoToDetailsPage(ReceivedEmail email)
        {
            await Shell.Current.GoToAsync(nameof(DetailsPage), true, new Dictionary<string, object>
            {
                {"Email", email }
            });
        }

        /// <summary>
        /// Opens selected page
        /// </summary>
        /// <param name="page">Name of the page to be opened</param>
        /// <returns>Instance of <see cref="Task"/></returns>
        [RelayCommand]
        private async Task GoToPage(string page)
        {
            await Shell.Current.GoToAsync(page, true);
        }

        #endregion

    }
}

using MauiGmailClone.Models;
using System.Text.Json;

namespace MauiGmailClone.Services
{
    /// <summary>
    /// Service that handles interactions with the user's emails
    /// </summary>
    public class EmailService
    {
        #region Private members

        /// <summary>
        /// List of all available emails
        /// </summary>
        private List<ReceivedEmail> _emails;

        #endregion


        #region Public methods

        /// <summary>
        /// Gets emails from a selected random group
        /// </summary>
        /// <returns>List of emails</returns>
        public async Task<List<ReceivedEmail>> GetEmails()
        {
            if (_emails == null)
                _emails = await GetAllEmails();

            var rand = new Random();
            int num = rand.Next(1, 6);
            var emails = _emails.Where(x => x.GroupId == num).ToList();

            return emails;
        } 

        #endregion


        #region Private methods

        /// <summary>
        /// Reads all available emails from a storage
        /// This app's emails are stored in a flat file
        /// </summary>
        /// <returns>List of emails</returns>
        private async Task<List<ReceivedEmail>> GetAllEmails()
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("EmailsMockData.json");
            using var reader = new StreamReader(stream);
            var contents = await reader.ReadToEndAsync();
            var emails = JsonSerializer.Deserialize<List<ReceivedEmail>>(contents);

            return emails;
        } 

        #endregion
    }
}


namespace MauiGmailClone.Models
{
    /// <summary>
    /// A Model for received email
    /// </summary>
    public class ReceivedEmail
    {
        /// <summary>
        /// Email group
        /// </summary>
        public int GroupId { get; set; }

        /// <summary>
        /// Sender email address
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Sender first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Sender last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Sender avatar image name
        /// </summary>
        public string AvatarType { get; set; }

        /// <summary>
        /// Email received date
        /// </summary>
        public string ReceivedDateStamp { get; set; }

        /// <summary>
        /// Email received time
        /// </summary>
        public string ReceivedTimeStamp { get; set; }

        /// <summary>
        /// Email subject text
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Email content text
        /// </summary>
        public string Content { get; set; }
    }
}

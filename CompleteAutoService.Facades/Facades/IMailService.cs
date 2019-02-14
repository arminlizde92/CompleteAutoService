namespace CompleteAutoService.Facades
{
    /// <summary>
    /// facade for mail services
    /// </summary>
    public interface IMailService
    {
        /// <summary>
        /// sends mail
        /// </summary>
        /// <param name="recipient">mail from the recipient</param>
        /// <param name="subject">subject of the mail</param>
        /// <param name="body">body of the mail</param>
        void Send(string recipient, string subject, string body);
    }
}

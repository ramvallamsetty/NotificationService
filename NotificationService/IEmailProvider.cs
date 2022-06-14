namespace NotificationService
{
    public class IEmailProvider
    {
        public string Provider; 
        public IEmailProvider(string provider)
        {            
            Provider = provider;
        }
    }
}
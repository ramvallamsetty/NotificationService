namespace NotificationService
{
    public class ISMSSender
    {
        public string Provider; 
        public ISMSSender(string provider)
        {            
            Provider = provider;
        }
    }
}
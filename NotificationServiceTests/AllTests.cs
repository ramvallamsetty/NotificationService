using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NotificationService; 

namespace NotificationServiceTests
{
    [TestClass]
    public class AllTests
    {
        [TestMethod]
        public void CreateUserTest()
        {
            UserService userService = new UserService();
            userService.CreateRegistration("John", "john@abc.com", "17032589635", DateTime.Now, true);

            Assert.IsTrue(userService.GetUser() != null);
        }
        [TestMethod]
        public void EnsureEmailNotificationIsSent()
        {
            UserService userService = new UserService();
            userService.CreateRegistration("John", "john@abc.com", "17032589635", DateTime.Now, true);

            INotification notification = new EmailNotification(userService.GetUser().GetEmailAddress(), new IEmailProvider("Mock Email Provider"));
            bool emailResult = notification.Notify("sub", "msg");
            Assert.IsTrue(emailResult);
        }
        [TestMethod]
        public void EnsureEmailNotificationForUserIsSent()
        {
            UserService userService = new UserService();
            userService.CreateRegistration("John", "john@abc.com", "17032589635", DateTime.Now, true);

            INotification notification = new EmailNotification(userService.GetUser(), new IEmailProvider("Mock Email Provider"));
            bool emailResult = notification.Notify("sub", "msg");
            Assert.IsTrue(emailResult);
        }
        [TestMethod]
        public void EnsureSMSNotificationIsSent()
        {
            UserService userService = new UserService();
            userService.CreateRegistration("John", "john@abc.com", "17032589635", DateTime.Now, true);

            INotification notification = new SMSNotification("7035585541", new ISMSSender("Mock SMS Provider"));
            bool smsResult = notification.Notify("sub", "msg");
            Assert.IsTrue(smsResult);
        }
        [TestMethod]
        public void EnsureSMSNotificationForUserIsSent()
        {
            UserService userService = new UserService();
            userService.CreateRegistration("John", "john@abc.com", "17032589635", DateTime.Now, true);

            INotification notification = new SMSNotification(userService.GetUser(), new ISMSSender("Mock SMS Provider"));
            bool smsResult = notification.Notify("sub", "msg");
            Assert.IsTrue(smsResult);
        }
    }
}

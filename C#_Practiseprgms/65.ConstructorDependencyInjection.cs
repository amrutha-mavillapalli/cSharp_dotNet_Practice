namespace MyPractise
{
    public class ClsConstructorDependencyInjection
    {
       public interface IMessageService
        {
            void SendMessage(string message);
        }
        public class EmailService : IMessageService
        {
            public void SendMessage(string message)
            {
                Console.WriteLine("Email sent:"+ message);
            }
        }

        public class SmsService: IMessageService
        {
            public void SendMessage(string message)
            {
                Console.WriteLine("SMS sent:"+ message);
            }
        }

        public class Notification
        {
            private IMessageService _messageService;
            public Notification(IMessageService messageService)
            {
                _messageService = messageService;
            }
            public void Notify(string message)
            {
                _messageService.SendMessage(message);
            }
        }

        public static void ConstructorDependencyInjectionExample()
        {
            // Using EmailService
            IMessageService emailService = new EmailService();
            Notification emailNotification = new Notification(emailService);
            emailNotification.Notify("Hello via Email!");

            // Using SmsService
            IMessageService smsService = new SmsService();
            Notification smsNotification = new Notification(smsService);
            smsNotification.Notify("Hello via SMS!");
        }
    }
}
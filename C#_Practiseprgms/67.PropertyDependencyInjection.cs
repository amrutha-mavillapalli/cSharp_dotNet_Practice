namespace MyPractise
{
    public class ClsPropertyDependencyInjection
    {
        public interface IMessageService
        {
            void SendMessage(string message);
        }
        public class EmailService : IMessageService
        {
            public void SendMessage(string message)
            {
                Console.WriteLine("Email sent:" + message);
            }
        }

        public class Notification
        {
            // Property Injection
            public IMessageService MessageService { get; set; }

            public void Notify(string message)
            {
                if (MessageService != null)
                {
                    MessageService.SendMessage(message);
                }
                else
                {
                    Console.WriteLine("MessageService is not set.");
                }
            }
        }

        public static void PropertyDependencyInjectionExample()
        {
            Notification notification = new Notification();

            // Using EmailService
            notification.MessageService = new EmailService();
            notification.Notify("Hello via Email!");

        }
    }
}
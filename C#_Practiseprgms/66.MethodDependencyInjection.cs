namespace  MyPractise
{
    public class ClsMethodDependencyInjection
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
            // Method Injection
            public void Notify(IMessageService messageService, string message)
            {
                messageService.SendMessage(message);
            }
        }

        public static void MethodDependencyInjectionExample()
        {
            Notification notification = new Notification();

            // Using EmailService
            IMessageService emailService = new EmailService();
            notification.Notify(emailService, "Hello via Email!");

        }
    }
}
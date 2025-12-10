namespace MyPractise
{
    public class ClsEvent
    {
        public class publisher
        {
             // Define a delegate (if using non-generic pattern).
        public delegate void Notify();  

        // Define an event based on that delegate.
        public event Notify OnPublish;  

            public void Publish()
            {
                Console.WriteLine("publishing...");

            }
        }
       
      public class subscriber
        {
            public void HandleNotification()
            {
                Console.WriteLine("Notification received!");
            }
        }

        public static void EventExample()
        {
            publisher pub = new publisher();
            subscriber sub = new subscriber();

            // Subscribe to the event
            pub.OnPublish += sub.HandleNotification;

            // Trigger the event
            pub.Publish();  
        }
    }
}
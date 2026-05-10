namespace MvcGitHub.Abstraction
{
    public abstract class NotificationCreator
    {
        public abstract INotification CreateNotification();

        public void SpecialMail()
        {
            Console.WriteLine("Special Email Post");
        }
        public string Notify(string notifycationType)
        {

            INotification notification = CreateNotification();
          return  notification.Send(notifycationType);

        }
    }
}

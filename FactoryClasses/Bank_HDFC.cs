using MvcGitHub.Abstraction;

namespace MvcGitHub.FactoryClasses
{
    public class Bank_HDFC: NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new Email();
        }
    }
}

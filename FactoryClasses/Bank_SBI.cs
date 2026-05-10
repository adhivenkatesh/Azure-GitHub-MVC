using MvcGitHub.Abstraction;

namespace MvcGitHub.FactoryClasses
{
    public class Bank_SBI:NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new Post();
        }
    }
}

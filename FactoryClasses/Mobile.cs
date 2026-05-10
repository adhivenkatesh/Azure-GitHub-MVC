using MvcGitHub.Abstraction;

namespace MvcGitHub.FactoryClasses
{
    public class Mobile:INotification
    {
        public string Send(string message)
        {
            return message + " " + this.GetType().Name;

        }
    }
}

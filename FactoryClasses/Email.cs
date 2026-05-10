using MvcGitHub.Abstraction;

namespace MvcGitHub.FactoryClasses
{
    public class Email:INotification
    {
        public string Send(string message)
        {
            return message + " " + this.GetType().Name;
        }
    }
}

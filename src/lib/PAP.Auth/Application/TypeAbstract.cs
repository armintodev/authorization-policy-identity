using System.Reflection;

namespace PAP.Auth.Application
{
    internal abstract record TypeAbstract
    {
        public virtual Assembly GetAssembly()
        {
            return Assembly.GetExecutingAssembly();
        }
    }
}

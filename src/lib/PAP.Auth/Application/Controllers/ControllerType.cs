using System;
using System.Collections.Generic;
using System.Reflection;

namespace PAP.Auth.Application.Controllers
{
    internal abstract record ControllerType : TypeAbstract
    {
        public abstract IEnumerable<Type> GetControllers();
        public abstract IEnumerable<MethodInfo> GetActions();
    }
}

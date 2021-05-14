using System;
using System.Collections.Generic;
using System.Reflection;

namespace PAP.Auth.Application.RazorPages
{
    internal abstract record PageType : TypeAbstract
    {
        public abstract IEnumerable<Type> GetPages();
        public abstract IEnumerable<MethodInfo> GetHandlers();
    }
}

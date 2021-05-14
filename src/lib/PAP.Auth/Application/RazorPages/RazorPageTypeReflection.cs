using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PAP.Auth.Application.RazorPages
{
    internal record RazorPageTypeReflection : PageType
    {
        public override IEnumerable<Type> GetPages()
        {
            return GetAssembly().GetTypes()
                .Where(type => typeof(PageModel).IsAssignableFrom(type));
        }

        public override IEnumerable<MethodInfo> GetHandlers()
        {
            return GetPages().SelectMany(type => type.GetMethods())
                .Where(method => method.IsPublic && !method.IsDefined(typeof(NonHandlerAttribute))/* &&
                                 method.IsDefined(typeof(AuthorizePermissionAttribute))*/);
        }
    }
}

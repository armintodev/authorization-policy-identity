using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace PAP.Auth.Application.Controllers
{
    internal record ControllerTypeReflection : ControllerType
    {
        public override IEnumerable<Type> GetControllers()
        {
            return GetAssembly().GetTypes()
                .Where(type => typeof(Controller).IsAssignableFrom(type) || typeof(ControllerBase).IsAssignableFrom(type));
        }

        public override IEnumerable<MethodInfo> GetActions()
        {
            return GetControllers().SelectMany(type => type.GetMethods())
                .Where(method => method.IsPublic && !method.IsDefined(typeof(NonActionAttribute))/* &&
                                 method.IsDefined(typeof(AuthorizePermissionAttribute))*/);
        }
    }
}

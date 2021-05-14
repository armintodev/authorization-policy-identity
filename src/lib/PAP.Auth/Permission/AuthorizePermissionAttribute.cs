using System;

namespace PAP.Auth.Permission
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class AuthorizePermissionAttribute : Attribute
    {
        public string Permission { get; set; }
        public AuthorizePermissionAttribute(string permission)
        {
            Permission = permission;
        }

    }
}

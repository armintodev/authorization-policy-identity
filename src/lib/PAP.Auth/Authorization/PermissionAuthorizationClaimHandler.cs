using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using PAP.Auth.Requirements;

namespace PAP.Auth.Authorization
{
    internal class PermissionAuthorizationClaimHandler : AuthorizationHandler<Requirement>
    {
        public PermissionAuthorizationClaimHandler() { }
        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, Requirement requirement)
        {
            if (context?.User is null)
            {
                return;
            }
            var requirementClaims = context.User.Claims.Where(x =>
                 x.Type == typeof(Requirement).GetProperty("Name")?.GetValue(null)?.ToString() &&
                 x.Value == requirement.Name
                 );

            if (requirementClaims.Any())
            {
                context.Succeed(requirement);
                return;
            }
        }
    }
}

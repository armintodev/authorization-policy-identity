using Microsoft.AspNetCore.Authorization;

namespace PAP.Auth.Requirements
{
    public record Requirement<TKey>(TKey Name) : IAuthorizationRequirement;

    public record Requirement(string Name) : Requirement<string>(Name);
}
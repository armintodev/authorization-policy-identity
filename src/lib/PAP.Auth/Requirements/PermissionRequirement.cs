namespace PAP.Auth.Requirements
{
    internal sealed record PermissionRequirement(string Permission) : Requirement(Permission);
}

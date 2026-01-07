namespace ResponseResult.Models.Responses.Identity
{
    public class RoleClaimsResponse
    {
        public RoleResponse Role { get; set; }
        public List<RoleClaimViewModel> RoleClaims { get; set; }
    }
}

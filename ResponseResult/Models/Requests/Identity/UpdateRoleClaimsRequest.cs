using ResponseResult.Models.Responses.Identity;

namespace ResponseResult.Models.Requests.Identity
{
    public class UpdateRoleClaimsRequest
    {
        public string RoleId { get; set; }
        public List<RoleClaimViewModel> RoleClaims { get; set; }
    }
}

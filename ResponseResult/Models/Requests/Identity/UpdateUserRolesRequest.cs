using ResponseResult.Models.Responses.Identity;

namespace ResponseResult.Models.Requests.Identity
{
    public class UpdateUserRolesRequest
    {
        public string UserId { get; set; }
        public List<UserRoleViewModel> Roles { get; set; }
    }
}

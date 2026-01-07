using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponseResult.Models.Requests.Identity
{
    public class UpdateRoleRequest
    {
        public string RoleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

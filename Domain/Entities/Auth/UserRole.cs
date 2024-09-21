using Domain.Entities.Common;
using Domain.Enums;
using Domain.ValueObjects.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Auth
{
    public class UserRole : BaseEntity<UserRolesId, Guid>
    {
        public override UserRolesId Id { get; set; }  = new UserRolesId(Guid.NewGuid());

        public string Name { get; set; } = string.Empty;

        public RoleAccessLevel AccessLevel { get; set; } = RoleAccessLevel.None;
    }
}

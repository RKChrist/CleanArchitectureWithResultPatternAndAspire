using Domain.Entities.Auth;
using Domain.Entities.Common;
using Domain.ValueObjects.Auth;
using Domain.ValueObjects.Management;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Management
{

    [Table("tblUser")]
    public class User : BaseEntity<UserId, Guid>
    {

        [Column("userId")]
        public override UserId Id { get; set; } = new UserId(Guid.NewGuid());
        [Column("userName")]
        public string Name { get; set; } = string.Empty;
        [Column("userEmail")]
        public string Email { get; set; } = string.Empty;
        [Column("userPassword")]
        public string Password { get; set; } = string.Empty;
        [Column("userActive")]
        public bool Active { get; set; } = true;

        [Column("userRoleId")]
        public UserRolesId RoleId { get; set; }

        public UserRole Role { get; set; } = new UserRole();
    }
}

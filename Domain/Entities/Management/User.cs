using Domain.Entities.Common;
using Domain.ValueObjects.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Management
{
    public class User : BaseEntity<UserId>
    {
        public override UserId Id { get; set; } = new UserId(Guid.NewGuid());

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public bool Active { get; set; } = true;

    }
}

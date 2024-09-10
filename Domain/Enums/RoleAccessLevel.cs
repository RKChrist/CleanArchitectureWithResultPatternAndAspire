using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum  RoleAccessLevel
    {
        None = 1,
        Reader = 100,
        User = 500,
        Moderator = 1000,
        Admin = 1500,
        SuperAdmin = 2000
    }
}

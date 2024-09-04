using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Auth
{
    public interface ICurrentUser
    {
        int? UserId { get; }
        bool IsAuthenticated { get; }
    }
}

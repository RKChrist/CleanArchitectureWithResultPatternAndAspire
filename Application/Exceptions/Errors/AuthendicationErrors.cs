using Application.Exceptions.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions.Errors
{
    public class AuthendicationErrors
    {
        public static Error InvalidCredentials =>  Error.Validation("Invalid Credentials", "Couldn't Authorize with the Username or Password");
    }
}

using Application.Interfaces.MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handlers.Security.Auth.Commands.Login
{
    public class LoginCommand : ICommand
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public bool RememberMe { get; set; }
    }
}

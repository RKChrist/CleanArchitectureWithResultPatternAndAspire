using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.MediatR
{
    public interface IQuery : IRequest
    {
    }

    public interface IQuery<T> : IRequest<T>
    {
    }
}

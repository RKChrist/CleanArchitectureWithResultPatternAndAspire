using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.MediatR
{
    public interface ICommandHandler<in ICommand, TResult> : IRequestHandler<ICommand, TResult>
        where ICommand : ICommand<TResult>
    {
    }

    public interface ICommandHandler<TEntity> : IRequestHandler<TEntity>
        where TEntity : ICommand
    {
    }
}

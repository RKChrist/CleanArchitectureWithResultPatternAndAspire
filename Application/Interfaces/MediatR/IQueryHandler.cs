using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.MediatR
{
    public interface IQueryHandler<in IQuery, TResult> : IRequestHandler<IQuery, TResult>
        where IQuery : IQuery<TResult>

    {
    }

    public interface IQueryHandler<TEntity> : IRequestHandler<TEntity>
        where TEntity : IQuery
    {
    }
}

using Domain.ValueObjects.Common;
using Domain.ValueObjects.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects.Auth
{
    public class UserRolesId : TypedId<Guid>
    {
        /// <summary>
        /// Initializes a new instance of the CustomerId class with the specified Guid value.
        /// </summary>
        /// <param name="value">The Guid value representing the customer ID.</param>
        public UserRolesId(Guid value) : base(value) { }

        /// <summary>
        /// Implicit conversion from Guid to CustomerId.
        /// </summary>
        /// <param name="value">The Guid value.</param>
        /// <returns>A new instance of CustomerId.</returns>
        public static implicit operator UserRolesId(Guid value) => new UserRolesId(value);

        /// <summary>
        /// Implicit conversion from CustomerId to Guid.
        /// </summary>
        /// <param name="customerId">The CustomerId instance.</param>
        /// <returns>The underlying Guid value.</returns>
        public static implicit operator Guid(UserRolesId customerId) => customerId.Value;
    }
}
}

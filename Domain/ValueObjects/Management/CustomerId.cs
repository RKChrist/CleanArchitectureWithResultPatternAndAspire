using Domain.ValueObjects.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects.Management
{
    /// <summary>
    /// A strongly typed ID for customers, based on a Guid.
    /// </summary>
    public class CustomerId : TypedId<Guid>
    {
        /// <summary>
        /// Initializes a new instance of the CustomerId class with the specified Guid value.
        /// </summary>
        /// <param name="value">The Guid value representing the customer ID.</param>
        public CustomerId(Guid value) : base(value) { }

        /// <summary>
        /// Implicit conversion from Guid to CustomerId.
        /// </summary>
        /// <param name="value">The Guid value.</param>
        /// <returns>A new instance of CustomerId.</returns>
        public static implicit operator CustomerId(Guid value) => new CustomerId(value);

        /// <summary>
        /// Implicit conversion from CustomerId to Guid.
        /// </summary>
        /// <param name="customerId">The CustomerId instance.</param>
        /// <returns>The underlying Guid value.</returns>
        public static implicit operator Guid(CustomerId customerId) => customerId.Value;
    }

}

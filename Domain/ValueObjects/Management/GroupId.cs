using Domain.ValueObjects.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects.Management
{
    /// <summary>
    /// A strongly typed ID for Groups, based on a Guid.
    /// </summary>
    public class GroupId : TypedId<Guid>
    {
        /// <summary>
        /// Initializes a new instance of the GroupId class with the specified Guid value.
        /// </summary>
        /// <param name="value">The Guid value representing the Group ID.</param>
        public GroupId(Guid value) : base(value) { }

        /// <summary>
        /// Implicit conversion from Guid to GroupId.
        /// </summary>
        /// <param name="value">The Guid value.</param>
        /// <returns>A new instance of GroupId.</returns>
        public static implicit operator GroupId(Guid value) => new GroupId(value);

        /// <summary>
        /// Implicit conversion from GroupId to Guid.
        /// </summary>
        /// <param name="groupId">The GroupId instance.</param>
        /// <returns>The underlying Guid value.</returns>
        public static implicit operator Guid(GroupId groupId) => groupId.Value;
    }
}

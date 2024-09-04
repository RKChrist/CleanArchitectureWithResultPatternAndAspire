using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects.Common
{
    /// <summary>
    /// A generic base class for strongly typed IDs, derived from BaseValueObject. 
    /// Supports strongly typed IDs based on an underlying value of type T, with equality and hash code logic inherited from BaseValueObject.
    /// </summary>
    /// <typeparam name="T">The underlying type of the ID (e.g., int, Guid).</typeparam>
    public abstract class TypedId<T> : BaseValueObject
    {
        /// <summary>
        /// Gets the underlying value of the strongly typed ID.
        /// </summary>
        public T Value { get; } = default!;

        /// <summary>
        /// Initializes a new instance of the TypedId class with the specified value.
        /// </summary>
        /// <param name="value">The underlying value of the ID.</param>
        protected TypedId(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "ID cannot be null.");
            }
            Value = value;
        }

        /// <summary>
        /// Provides the equality components of the strongly typed ID, which is the underlying value.
        /// </summary>
        /// <returns>An enumerable containing the underlying value of the ID.</returns>
        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return Value;
        }

        /// <summary>
        /// Implicit conversion from the underlying type (T) to the strongly typed ID.
        /// </summary>
        /// <param name="value">The underlying value.</param>
        /// <returns>A new instance of TypedId.</returns>
        public static implicit operator TypedId<T>?(T value)
        {
            return Activator.CreateInstance(typeof(TypedId<T>), value) as TypedId<T>;
        }

        /// <summary>
        /// Implicit conversion from the strongly typed ID to the underlying type (T).
        /// </summary>
        /// <param name="id">The strongly typed ID.</param>
        /// <returns>The underlying value of the ID.</returns>
        public static implicit operator T(TypedId<T> id)
        {
            return id.Value;
        }

        /// <summary>
        /// Returns a string that represents the current strongly typed ID.
        /// </summary>
        /// <returns>The string representation of the underlying value.</returns>
        public override string? ToString()
        {
            if(Value == null)
            {
                return string.Empty;
            }
            return Value.ToString();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects.Common
{
    /// <summary>
    /// Abstract base class for value objects in Domain-Driven Design (DDD).
    /// It provides basic equality comparison and hash code generation logic for value objects.
    /// Derived classes must define which components should be used for equality comparisons.
    /// </summary>
    public abstract class BaseValueObject
    {
        /// <summary>
        /// Defines the components of the value object that are used to determine equality.
        /// Derived classes must implement this method to specify the values that should be considered for equality checks.
        /// </summary>
        /// <returns>An enumerable collection of object components to be used for equality comparison.</returns>
        protected abstract IEnumerable<object?> GetEqualityComponents();

        /// <summary>
        /// Compares two value objects for equality using the "==" operator.
        /// Handles cases where one or both objects are null and checks equality using the Equals method.
        /// </summary>
        /// <param name="left">The first value object.</param>
        /// <param name="right">The second value object.</param>
        /// <returns>True if both objects are equal, false otherwise.</returns>
        protected static bool EqualOperator(BaseValueObject? left, BaseValueObject? right)
        {
            // XOR check: If one is null and the other is not, they are not equal.
            if (ReferenceEquals(left, objB: null) ^ ReferenceEquals(right, objB: null)) return false;

            // If both are null, they are equal; otherwise check equality via the Equals method.
            return ReferenceEquals(left, objB: null) || left.Equals(right);
        }

        /// <summary>
        /// Compares two value objects for inequality using the "!=" operator.
        /// </summary>
        /// <param name="left">The first value object.</param>
        /// <param name="right">The second value object.</param>
        /// <returns>True if the objects are not equal, false if they are equal.</returns>
        protected static bool NotEqualOperator(BaseValueObject left, BaseValueObject right)
        {
            // Return the negation of the EqualOperator check.
            return !(EqualOperator(left, right));
        }

        /// <summary>
        /// Overrides the base Equals method to provide custom equality logic for value objects.
        /// It compares the equality components of the current object with those of another object.
        /// </summary>
        /// <param name="obj">The object to compare with the current value object.</param>
        /// <returns>True if the objects are equal, false otherwise.</returns>
        public override bool Equals(object? obj)
        {
            // If the object is null or the types don't match, they are not equal.
            if (obj == null || obj.GetType() != GetType()) return false;

            // Cast the object to the same type and compare their equality components.
            var other = (BaseValueObject)obj;

            // Compare the sequences of equality components from both objects.
            return this.GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
        }

        /// <summary>
        /// Overrides the base GetHashCode method to generate a hash code for the value object.
        /// Combines the hash codes of all equality components to create a unique hash code.
        /// </summary>
        /// <returns>An integer representing the hash code for the value object.</returns>
        public override int GetHashCode()
        {
            // Select the hash code for each equality component, using 0 if the component is null.
            return GetEqualityComponents()
                  .Select(x => x != null
                                   ? x.GetHashCode() // Get hash code for non-null components.
                                   : 0)              // Use 0 for null components.
                  .Aggregate((x, y) => x ^ y);      // XOR all hash codes together to create a single hash code.
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects.Common
{
    // Abstract base class for value objects in Domain-Driven Design (DDD).
    // It provides basic equality comparison and hash code generation logic for value objects.
    public abstract class BaseValueObject
    {
        // This method must be implemented by derived classes to define which components of the object
        // should be used for equality checks.
        protected abstract IEnumerable<object?> GetEqualityComponents();

        // Static helper method to check if two value objects are equal using the "== operator".
        // It handles the case where one or both objects are null.
        protected static bool EqualOperator(BaseValueObject? left, BaseValueObject? right)
        {
            // XOR check: If one is null and the other is not, they are not equal.
            if (ReferenceEquals(left, objB: null) ^ ReferenceEquals(right, objB: null)) return false;

            // If both are null, they are equal, otherwise check equality via the Equals method.
            return ReferenceEquals(left, objB: null) || left.Equals(right);
        }

        // Static helper method to check if two value objects are not equal using the "!= operator".
        protected static bool NotEqualOperator(BaseValueObject left, BaseValueObject right)
        {
            // Return the negation of the EqualOperator check.
            return !(EqualOperator(left, right));
        }

        // Overrides the base Equals method to provide custom equality logic for value objects.
        public override bool Equals(object? obj)
        {
            // If the object is null or the types don't match, they are not equal.
            if (obj == null || obj.GetType() != GetType()) return false;

            // Cast the object to the same type and compare their equality components.
            var other = (BaseValueObject)obj;

            // Compare the sequences of equality components from both objects.
            return this.GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
        }

        // Overrides the base GetHashCode method to provide a custom hash code generation for value objects.
        // It generates a hash code by combining the hash codes of all equality components.
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

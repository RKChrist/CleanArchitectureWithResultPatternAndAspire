using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Extensions
{
    public static class ListExtension
    {
        public static void Move<T>(this List<T> list, int oldIndex, int newIndex)
        {
            // exit if positions are equal or outside array
            if ((oldIndex == newIndex) || (0 > oldIndex) || (oldIndex >= list.Count) || (0 > newIndex) ||
                (newIndex >= list.Count)) return;
            // local variables
            var i = 0;
            T tmp = list[oldIndex];
            // move element down and shift other elements up
            if (oldIndex < newIndex)
            {
                for (i = oldIndex; i < newIndex; i++)
                {
                    list[i] = list[i + 1];
                }
            }
            // move element up and shift other elements down
            else
            {
                for (i = oldIndex; i > newIndex; i--)
                {
                    list[i] = list[i - 1];
                }
            }
            // put element from position 1 to destination
            list[newIndex] = tmp;
        }

        //
        // Summary:
        //     Checks whether enumerable is null or empty.
        //
        // Parameters:
        //   enumerable:
        //     The System.Collections.Generic.IEnumerable`1 to be checked.
        //
        // Type parameters:
        //   T:
        //     The type of the enumerable.
        //
        // Returns:
        //     True if enumerable is null or empty, false otherwise.
        // From:
        //     Microsoft.IdentityModel.Tokens.CollectionUtilities
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable != null)
            {
                return !enumerable.Any();
            }

            return true;
        }

        public static void AddIfUnique<T>(this List<T> list, T item)
        {
            if (!list.Contains(item))
                list.Add(item);
        }

        public static void AddRangeIfUnique<T>(this List<T> list, IEnumerable<T> items)
        {
            if (items == null) return;
            foreach (var item in items)
            {
                list.AddIfUnique(item);
            }
        }
    }
}

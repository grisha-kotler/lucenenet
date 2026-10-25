using System;
using System.Buffers;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Lucene.Net.Util
{
    /// <summary>
    /// Pooled arrays for the per-hit storage of the top-docs collectors: the hit queue heap and the comparator slot
    /// arrays. Those used to be allocated fresh for every search at the number of hits requested, which for a query
    /// that asks for every document is the size of the index, and discarded right after, churning the large object
    /// heap on every such query. Here they are rented from the shared pool and returned when the collector is
    /// disposed, so one search after another reuses the same buffers.
    /// </summary>
    public static class PooledArray<T>
    {
        // the shared pool trims its buffers under memory pressure, so a one-off huge sort does not pin memory forever
        private static readonly ArrayPool<T> Pool = ArrayPool<T>.Shared;

        /// <summary>Rents an array that holds at least <paramref name="length"/> elements.</summary>
        public static T[] Rent(int length)
        {
            return Pool.Rent(Math.Max(1, length));
        }

        /// <summary>
        /// Returns an array whose slots hold value types. A stale slot is never read, so nothing is cleared.
        /// </summary>
        public static void Return(T[] array)
        {
            Debug.Assert(RuntimeHelpers.IsReferenceOrContainsReferences<T>() == false, "slots that hold references must go through ReturnWithClearing");
            if (array == null)
                return;

            Pool.Return(array);
        }

        /// <summary>
        /// Returns an array whose slots hold references, clearing the first <paramref name="usedLength"/> slots first so
        /// nothing stays alive through the pool. Only the slots that were written are cleared, which keeps the return
        /// cheap for a large array that held a handful of hits.
        /// </summary>
        public static void ReturnWithClearing(T[] array, int usedLength)
        {
            if (array == null)
                return;

            Array.Clear(array, 0, Math.Min(usedLength, array.Length));
            Pool.Return(array);
        }
    }
}

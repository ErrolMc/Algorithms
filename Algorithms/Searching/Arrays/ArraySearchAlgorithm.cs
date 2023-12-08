
using System.Diagnostics;

namespace Algorithms.Searching.Arrays
{
    public abstract class ArraySearchAlgorithm
    {
        public abstract Item FindItem(List<Item> items, int id);

        public ItemResult FindItemTimed(List<Item> items, int id)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Item item = FindItem(items, id);
            stopwatch.Stop();
            return new ItemResult(item, stopwatch.Elapsed.Ticks);
        }
    }
}

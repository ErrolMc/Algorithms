using System.Diagnostics;

namespace Algorithms.Searching.Arrays
{
    public class SearchArrayRunner : AlgorithmRunner
    {
        public override void Run()
        {
            List<Item> items = Item.GenerateItems(100000, 0, 1000000);

            Stopwatch sortStopwatch = Stopwatch.StartNew();
            List<Item> itemsSorted = items.OrderBy(item => item.Id).ToList();
            sortStopwatch.Stop();

            Item itemToFind = items[Program.Random.Next(items.Count)];

            // random array
            ItemResult linear = new LinearSearch().FindItemTimed(items, itemToFind.Id);

            // sorted array
            ItemResult linearSorted = new LinearSearch().FindItemTimed(itemsSorted, itemToFind.Id);
            ItemResult binary = new BinarySearch().FindItemTimed(itemsSorted, itemToFind.Id);
            ItemResult interpolation = new InterpolationSearch().FindItemTimed(itemsSorted, itemToFind.Id);

            Console.WriteLine("Search Array Algorithms: ");
            Console.WriteLine("Random Array: ");
            Console.WriteLine($"[Linear] {linear}");

            Console.WriteLine();

            Console.WriteLine($"Sorted Array, Sort Time: {sortStopwatch.ElapsedTicks}:");
            Console.WriteLine($"[Linear] {linearSorted}");
            Console.WriteLine($"[Binary] {binary}");
            Console.WriteLine($"[Interpolation] {interpolation}");
        }
    }
}

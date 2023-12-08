
namespace Algorithms.Searching.Arrays
{
    public class BinarySearch : ArraySearchAlgorithm
    {
        public override Item FindItem(List<Item> items, int id)
        {
            int low = 0;
            int high = items.Count - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                Item cur = items[mid];

                if (cur.Id == id)
                {
                    return cur;
                }
                else if (cur.Id < id)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return null;
        }
    }
}

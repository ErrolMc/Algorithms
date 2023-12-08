
namespace Algorithms.Searching.Arrays
{
    public class InterpolationSearch : ArraySearchAlgorithm
    {
        public override Item FindItem(List<Item> items, int id)
        {
            int low = 0;
            int high = items.Count - 1;
            int prevPos = -1;

            while (low <= high && id >= items[low].Id && id <= items[high].Id)
            {
                // Ensure that the denominator is not zero
                int denominator = Math.Max(1, items[high].Id - items[low].Id);
                int pos = low + ((id - items[low].Id) * (high - low) / denominator);

                if (pos == prevPos)
                    return null;

                if (pos < 0 || pos >= items.Count)
                {
                    // Avoid potential index out of bounds
                    return null;
                }

                Item cur = items[pos];

                if (cur.Id == id)
                {
                    return cur;
                }
                else if (cur.Id < id)
                {
                    low = pos + 1;
                }
                else
                {
                    high = pos - 1;
                }

                prevPos = pos;
            }

            return null;
        }
    }
}


namespace Algorithms.Searching.Arrays
{
    public class LinearSearch : ArraySearchAlgorithm
    {
        public override Item FindItem(List<Item> items, int id)
        {
            foreach (var item in items)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }
    }
}


using System;

namespace Algorithms.Searching.Arrays
{
    public class Item
    {
        public int Id { get; set; }
        public string Label { get; set; }

        public Item(int id, string label)
        {
            Id = id;
            Label = label;
        }

        public static List<Item> GenerateItems(int amount)
        {
            List<Item> items = new List<Item>();
            for (int i = 0; i < amount; i++)
                items.Add(new Item(i, Names.RandomName()));
            return items;
        }

        public static List<Item> GenerateItems(int amount, int min, int max)
        {
            if (amount <= 0 || min >= max || (max - min + 1) < amount)
            {
                throw new ArgumentException("Invalid input parameters.");
            }

            List<Item> items = new List<Item>();
            HashSet<int> generatedValues = new HashSet<int>();
            Random random = Program.Random;

            for (int i = 0; i < amount;)
            {
                int randomValue = random.Next(min, max + 1);

                if (generatedValues.Add(randomValue))
                {
                    items.Add(new Item(randomValue, Names.RandomName()));
                    i++;
                }
            }

            return items;
        }
    }

    public class ItemResult
    {
        public Item Item { get; set; }
        public long Time { get; set; }

        public ItemResult(Item item, long time)
        {
            Item = item;
            Time = time;
        }

        public override string ToString()
        {
            string status = Item == null ? "null" : "found";
            return $"Item {status}, Time: {Time}";
        }
    }
}

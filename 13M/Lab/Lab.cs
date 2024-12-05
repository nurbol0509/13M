using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> orderItems = new Dictionary<string, int>
        {
            { "item1", 2 },
            { "item2", 1 }
        };

        Dictionary<string, int> warehouseStock = new Dictionary<string, int>
        {
            { "item1", 5 },
            { "item2", 0 },
            { "item3", 10 }
        };

        List<string> unavailableItems = CheckAvailability(orderItems, warehouseStock);

        if (unavailableItems.Count > 0)
        {
            Console.WriteLine("Следующие товары недоступны:");
            foreach (string item in unavailableItems)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("Все товары в наличии.");
        }
    }

    static List<string> CheckAvailability(Dictionary<string, int> orderItems, Dictionary<string, int> warehouseStock)
    {
        List<string> unavailableItems = new List<string>();

        foreach (var item in orderItems)
        {
            string itemName = item.Key;
            int requiredQuantity = item.Value;

            if (!warehouseStock.ContainsKey(itemName) || warehouseStock[itemName] < requiredQuantity)
            {
                unavailableItems.Add(itemName);
            }
        }

        return unavailableItems;
    }
}

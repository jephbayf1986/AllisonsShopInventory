using AllisonsShopInventory.InventoryItems;
using System;
using System.Collections.Generic;

namespace AllisonsShopInventory.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome back, Allison!");

            IList<InventoryItem> InventoryList = new List<InventoryItem>();

            InventoryMenu.Options(InventoryList);
        }
    }
}

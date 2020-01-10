using AllisonsShopInventory.Helpers;
using AllisonsShopInventory.InventoryItems;
using System;
using System.Collections.Generic;

namespace AllisonsShopInventory.InventoryActions
{
    public static class InventoryReader
    {
        public static void Read(IList<InventoryItem> inventoryList)
        {
            if (inventoryList.Count == 0)
            {
                Console.WriteLine("You currently have no Items in your Inventory, to add one, select option 2:");
            }
            else
            {
                Console.WriteLine("Here is your current inventory:");
                ConsoleHelper.WriteHorizontalRule();

                foreach (InventoryItem inventoryitem in inventoryList)
                {
                    Console.WriteLine(inventoryitem.Print());
                }

                ConsoleHelper.WriteHorizontalRule();
                Console.WriteLine($"{inventoryList.Count} Item(s) total");
                ConsoleHelper.WriteHorizontalRule();
            }

            InventoryMenu.Options(inventoryList);
        }
    }
}
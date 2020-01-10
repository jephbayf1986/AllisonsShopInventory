using AllisonsShopInventory.Constants;
using AllisonsShopInventory.Helpers;
using AllisonsShopInventory.InventoryItems;
using System;
using System.Collections.Generic;

namespace AllisonsShopInventory.InventoryActions
{
    public static class InventoryCreator
    {
        public static void Create(IList<InventoryItem> inventoryList)
        {
            string itemName = ConsoleHelper.ReadString("Enter the Name of the new Item...");

            int itemSellin = ConsoleHelper.ReadInt("Enter the 'Sell In' days of the new Item...", "The 'Sell In' days must be a number! Please try again");

            int itemQuality = ConsoleHelper.ReadInt("Enter the Quality level of the new Item...", "The Quality level must be a number! Please try again");

            Dictionary<string, InventoryItem> InventoryChoice = new Dictionary<string, InventoryItem>
                { 
                    { InventoryNames.AgedBrie, new AgedBrie(itemSellin, itemQuality) },
                    { InventoryNames.ChristmasCracker, new ChristmasCracker(itemSellin, itemQuality) },
                    { InventoryNames.FreshItem, new FreshItem(itemSellin, itemQuality) },
                    { InventoryNames.FrozenItem, new FrozenItem(itemSellin, itemQuality) },
                    { InventoryNames.Soap, new Soap(itemSellin, itemQuality) }
                };

            if (InventoryChoice.ContainsKey(itemName))
            {
                inventoryList.Add(InventoryChoice[itemName]);
            }
            else
            {
                inventoryList.Add(new InvalidItem(itemName, itemSellin, itemQuality));
            }
            
            Console.WriteLine($"{itemName} has been added to your inventory, you now have {inventoryList.Count} items in total");
            ConsoleHelper.WriteHorizontalRule();

            InventoryMenu.Options(inventoryList);
        }
    }
}
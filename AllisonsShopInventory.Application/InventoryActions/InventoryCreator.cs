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
            string ItemName = ConsoleHelper.ReadString("Enter the Name of the new Item...");

            int ItemSellin = ConsoleHelper.ReadInt("Enter the 'Sell In' days of the new Item...", "The 'Sell In' days must be a number! Please try again");

            int ItemQuality = ConsoleHelper.ReadInt("Enter the Quality level of the new Item...", "The Quality level must be a number! Please try again");

            Dictionary<string, InventoryItem> InventoryChoice = new Dictionary<string, InventoryItem>
                { 
                    { InventoryNames.AgedBrie, new AgedBrie(ItemSellin, ItemQuality) },
                    { InventoryNames.ChristmasCracker, new ChristmasCracker(ItemSellin, ItemQuality) },
                    { InventoryNames.FreshItem, new FreshItem(ItemSellin, ItemQuality) },
                    { InventoryNames.FrozenItem, new FrozenItem(ItemSellin, ItemQuality) },
                    { InventoryNames.Soap, new Soap(ItemSellin, ItemQuality) }
                };

            if (InventoryChoice.ContainsKey(ItemName))
            {
                inventoryList.Add(InventoryChoice[ItemName]);
            }
            else
            {
                inventoryList.Add(new InvalidItem(ItemName, ItemSellin, ItemQuality));
            }
            
            Console.WriteLine($"{ItemName} has been added to your inventory, you now have {inventoryList.Count} items in total");
            ConsoleHelper.WriteHorizontalRule();

            InventoryMenu.Options(inventoryList);
        }
    }
}
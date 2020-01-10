using AllisonsShopInventory.Helpers;
using AllisonsShopInventory.InventoryItems;
using System.Collections.Generic;

namespace AllisonsShopInventory.InventoryActions
{
    public static class DemoInventory
    {
        public static void Load(IList<InventoryItem> inventoryList)
        {
            bool ConfirmLoad = ConsoleHelper.ReadBool("This remove any existing Inventory, are you sure?");

            if (ConfirmLoad)
            {
                inventoryList.Clear();

                // "Aged Brie 1 1"

                inventoryList.Add(new AgedBrie(1, 1));

                // "Christmas Crackers -1 2"

                inventoryList.Add(new ChristmasCracker(-1, 2));

                // "Christmas Crackers 9 2"

                inventoryList.Add(new ChristmasCracker(9, 2));

                // "Soap 2 2"

                inventoryList.Add(new Soap(2, 2));

                // "Frozen Item -1 55"

                inventoryList.Add(new FrozenItem(-1, 55));

                // "Frozen Item 2 2"

                inventoryList.Add(new FrozenItem(2, 2));

                // "INVALID ITEM 2 2"

                inventoryList.Add(new InvalidItem("INVALID ITEM", 2, 2));

                // "Fresh Item 2 2"

                inventoryList.Add(new FreshItem(2, 2));

                // "Fresh Item -1 5"

                inventoryList.Add(new FreshItem(-1, 5));

                InventoryReader.Read(inventoryList);
            }
            else
            {
                InventoryMenu.Options(inventoryList);
            }
        }
    }
}
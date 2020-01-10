using AllisonsShopInventory.Helpers;
using AllisonsShopInventory.InventoryItems;
using System.Collections.Generic;

namespace AllisonsShopInventory.InventoryActions
{
    public static class InventoryMaturer
    {
        public static void Mature(IList<InventoryItem> inventoryList)
        {
            bool ConfirmMature = ConsoleHelper.ReadBool("This will mature every Inventory Item by 1 Day, are you sure?");

            if (ConfirmMature)
            {
                foreach (InventoryItem inventoryItem in inventoryList)
                {
                    inventoryItem.MatureOvernight();
                }

                InventoryReader.Read(inventoryList);
            }
            else
            {
                InventoryMenu.Options(inventoryList);
            }
        }
    }
}
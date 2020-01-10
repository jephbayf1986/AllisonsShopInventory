using AllisonsShopInventory.InventoryActions;
using AllisonsShopInventory.InventoryItems;
using EasyConsole;
using System;
using System.Collections.Generic;

namespace AllisonsShopInventory
{
    public static class InventoryMenu
    {
        public static void Options(IList<InventoryItem> inventoryList)
        {
            Menu options = new Menu()
              .Add("View Inventory", () => InventoryReader.Read(inventoryList))
              .Add("Add an Item", () => InventoryCreator.Create(inventoryList))
              .Add("Mature Inventory", () => InventoryMaturer.Mature(inventoryList))
              .Add("Load Demo Inventory", () => DemoInventory.Load(inventoryList))
              .Add("Exit Program", () => Exit());

            options.Display();
        }

        private static void Exit()
        {
            Console.WriteLine("Goodbye Allison!");
        }
    }
}
using System;

namespace AllisonsShopInventory.InventoryItems
{
    public class InventoryItem
    {
        public string Name { get; protected set; }

        public int SellIn { get; protected set; }

        public int Quality { get; protected set; }

        protected bool IsValid;

        public InventoryItem(int sellIn, int quality)
        {
            SellIn = sellIn;

            Quality = quality;

            IsValid = true;
        }

        public virtual void MatureOvernight()
        {
            // "The Quality of an item is never more than 50"

            if (Quality > 50)
            {
                Quality = 50;
            }

            // "The Quality of an item is never negative"

            if (Quality < 0)
            {
                Quality = 0;
            }
        }

        public string Print()
        {
            if (IsValid)
            {
                return $"{Name} {SellIn} {Quality}";
            }

            return "NO SUCH ITEM";
        }
    }
}
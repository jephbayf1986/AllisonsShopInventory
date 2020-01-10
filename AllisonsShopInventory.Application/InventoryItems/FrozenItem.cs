using AllisonsShopInventory.Constants;

namespace AllisonsShopInventory.InventoryItems
{
    public class FrozenItem : InventoryItem
    {
        public FrozenItem(int sellIn, int quality)
            : base(sellIn, quality)
        {
            Name = InventoryNames.FrozenItem;
        }

        public override void MatureOvernight()
        {
            // "At the end of each day our system lowers both values for every item"

            if (SellIn != int.MinValue)
            {
                SellIn--;
            }

            if (Quality != int.MinValue)
            {
                Quality--;
            }

            // "Once the sell by date has passed, Quality degrades twice as fast "

            if (SellIn < 0)
            {
                if (Quality != int.MinValue)
                {
                    Quality--;
                }
            }

            base.MatureOvernight();
        }
    }
}
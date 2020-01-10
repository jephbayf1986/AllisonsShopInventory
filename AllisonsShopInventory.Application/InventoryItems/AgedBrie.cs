using AllisonsShopInventory.Constants;

namespace AllisonsShopInventory.InventoryItems
{
    public class AgedBrie : InventoryItem
    {
        public AgedBrie(int sellIn, int quality)
            : base(sellIn, quality)
        {
            Name = InventoryNames.AgedBrie;
        }

        public override void MatureOvernight()
        {
            // "At the end of each day our system lowers both values for every item"

            if (SellIn != int.MinValue)
            {
                SellIn--;
            }

            // "Aged Brie actually increases in Quality the older it gets"

            if (Quality != int.MaxValue)
            {
                Quality++;
            }

            base.MatureOvernight();
        }
    }
}

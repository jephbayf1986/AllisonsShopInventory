using AllisonsShopInventory.Constants;

namespace AllisonsShopInventory.InventoryItems
{
    public class FreshItem : InventoryItem
    {
        public FreshItem(int sellIn, int quality)
            : base(sellIn, quality)
        {
            Name = InventoryNames.FreshItem;
        }

        public override void MatureOvernight()
        {
            // "At the end of each day our system lowers both values for every item"

            if (SellIn != int.MinValue)
            {
                SellIn--;
            }

            // "Fresh Item degrade in Quality twice as fast as Frozen Item"

            QualityTake2();

            // "Once the sell by date has passed, Quality degrades twice as fast "

            if (SellIn < 0)
            {
                QualityTake2();
            }

            base.MatureOvernight();
        }

        private void QualityTake2()
        {
            if (Quality > int.MinValue + 1)
            {
                Quality = Quality - 2;
            }
            else
            {
                Quality = int.MinValue;
            }
        }
    }
}
using AllisonsShopInventory.Constants;

namespace AllisonsShopInventory.InventoryItems
{
    public class Soap : InventoryItem
    {
        public Soap(int sellIn, int quality)
            : base(sellIn, quality)
        {
            Name = InventoryNames.Soap;
        }

        public override void MatureOvernight()
        {
            // "Soap never has to be sold" hence should never be less than 1

            if (SellIn < 1)
            {
                SellIn = 1;
            }

            // "or decreases in Quality" hence do nothing

            base.MatureOvernight();
        }
    }
}
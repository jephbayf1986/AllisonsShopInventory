using AllisonsShopInventory.Constants;

namespace AllisonsShopInventory.InventoryItems
{
    public class ChristmasCracker : InventoryItem
    {
        public ChristmasCracker(int sellIn, int quality)
            : base(sellIn, quality)
        {
            Name = InventoryNames.ChristmasCracker;
        }

        public override void MatureOvernight()
        {
            // "At the end of each day our system lowers both values for every item"

            if (SellIn != int.MinValue)
            {
                SellIn--;
            }

            // "Christmas Crackers increases in Quality as its SellIn value approaches:

            if (SellIn > 10)
            {
                if (Quality != int.MaxValue)
                {
                    Quality++;
                }
            }

            // "Its quality increases by 2 when there are 10 days or less"

            else if (SellIn > 5)
            {
                if (Quality < int.MaxValue - 1)
                {
                    Quality = Quality + 2;
                }
                else
                {
                    Quality = int.MaxValue;
                }
            }

            // "and by 3 when there are 5 days or less"

            else if (SellIn >= 0)
            {
                if (Quality < int.MaxValue - 2)
                {
                    Quality = Quality + 3;
                }
                else
                {
                    Quality = int.MaxValue;
                }
            }

            // "but quality drops to 0 after Christmas"

            else
            {
                Quality = 0;
            }

            base.MatureOvernight();
        }
    }
}
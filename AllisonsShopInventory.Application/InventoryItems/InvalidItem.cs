namespace AllisonsShopInventory.InventoryItems
{
    public class InvalidItem : InventoryItem
    {
        public InvalidItem(string name, int sellIn, int quality)
            : base(sellIn, quality)
        {
            Name = name;
        }

        public override void MatureOvernight()
        {
            IsValid = false;
        }
    }
}
using AllisonsShopInventory.InventoryItems;
using Shouldly;
using Xunit;

namespace AllisonsShopInventory.UnitTesting.InventoryItems.InvalidUnitTests
{
    public class MatureUnitTest
    {
        [Fact]
        public void MarkAsInvalidUponMature()
        {
            // Arrange
            
            InventoryItem systemUnderTest = new InvalidItem("Something", 1, 2);

            // Act

            systemUnderTest.MatureOvernight();

            // Assert

            string result = systemUnderTest.Print();

            result.ShouldBe("NO SUCH ITEM");
        }
    }
}
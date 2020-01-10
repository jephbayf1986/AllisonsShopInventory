using AllisonsShopInventory.InventoryItems;
using Shouldly;
using Xunit;

namespace AllisonsShopInventory.UnitTesting.InventoryItems.SoapUnitTests
{
    public class MatureUnitTest
    {
        // For Range between 0 and 50
        [Theory]
        [InlineData(20, 0)]
        [InlineData(1, 1)]
        [InlineData(10, 10)]
        [InlineData(40, 40)]
        [InlineData(50, 50)]
        public void ValuesShouldNotChangeInRange(int sellIn, int quality)
        {
            // Arrange

            InventoryItem systemUnderTest = new Soap(sellIn, quality);

            // Act

            systemUnderTest.MatureOvernight();

            // Assert

            systemUnderTest.SellIn.ShouldBe(sellIn);
            systemUnderTest.Quality.ShouldBe(quality);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-20)]
        [InlineData(int.MinValue)]
        public void SellInShouldNeverBeLessThan1(int sellIn)
        {
            // Arrange

            InventoryItem systemUnderTest = new Soap(sellIn, 1);

            // Act

            systemUnderTest.MatureOvernight();

            // Assert

            systemUnderTest.SellIn.ShouldBe(1);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-20)]
        [InlineData(-50)]
        [InlineData(int.MinValue)]
        public void QualityShouldNeverBeNegative(int quality)
        {
            // Arrange

            InventoryItem systemUnderTest = new Soap(1, quality);

            // Act

            systemUnderTest.MatureOvernight();

            // Assert

            systemUnderTest.Quality.ShouldBe(0);
        }

        [Theory]
        [InlineData(51)]
        [InlineData(80)]
        [InlineData(int.MaxValue)]
        public void QualityShouldNeverBeOver50(int quality)
        {
            // Arrange

            InventoryItem systemUnderTest = new Soap(1, quality);

            // Act

            systemUnderTest.MatureOvernight();

            // Assert

            systemUnderTest.Quality.ShouldBe(50);
        }
    }
}

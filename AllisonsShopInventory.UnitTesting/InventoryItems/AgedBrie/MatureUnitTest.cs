using AllisonsShopInventory.InventoryItems;
using Shouldly;
using Xunit;

namespace AllisonsShopInventory.UnitTesting.InventoryItems.AgedBrieUnitTests
{
    public class MatureUnitTest
    {
        // For Range between 0 and 50
        [Theory]
        [InlineData(4, 0)]
        [InlineData(0, 4)]
        [InlineData(-10, 40)]
        [InlineData(int.MaxValue, 40)]
        public void QualityShouldIncreaseAsSellInDecreasesWithinRange(int sellIn, int quality)
        {
            // Arrange

            InventoryItem systemUnderTest = new AgedBrie(sellIn, quality);

            // Act

            systemUnderTest.MatureOvernight();

            // Assert

            systemUnderTest.SellIn.ShouldBe(sellIn - 1);
            systemUnderTest.Quality.ShouldBe(quality + 1);
        }

        [Fact]
        public void SellInShouldNotChangeAtMinValue()
        {
            // Arrange

            InventoryItem systemUnderTest = new AgedBrie(int.MinValue, 1);

            // Act

            systemUnderTest.MatureOvernight();

            // Assert

            systemUnderTest.SellIn.ShouldBe(int.MinValue);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-20)]
        [InlineData(-50)]
        [InlineData(int.MinValue)]
        public void QualityShouldNeverBeNegative(int quality)
        {
            // Arrange

            InventoryItem systemUnderTest = new AgedBrie(1, quality);

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

            InventoryItem systemUnderTest = new AgedBrie(1, quality);

            // Act

            systemUnderTest.MatureOvernight();

            // Assert

            systemUnderTest.Quality.ShouldBe(50);
        }
    }
}
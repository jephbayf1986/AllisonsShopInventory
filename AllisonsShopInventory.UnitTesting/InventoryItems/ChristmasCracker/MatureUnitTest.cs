using AllisonsShopInventory.InventoryItems;
using Shouldly;
using Xunit;

namespace AllisonsShopInventory.UnitTesting.InventoryItems.ChristmasCrackerUnitTests
{
    public class MatureUnitTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(6)]
        public void QualityIncreaseBy3Within5DaysOfChristmas(int sellIn)
        {
            // Arrange

            InventoryItem systemUnderTest = new ChristmasCracker(sellIn, 7);

            // Act

            systemUnderTest.MatureOvernight();

            // Assert

            systemUnderTest.SellIn.ShouldBe(sellIn - 1);
            systemUnderTest.Quality.ShouldBe(10);
        }

        [Theory]
        [InlineData(7)]
        [InlineData(9)]
        [InlineData(11)]
        public void QualityIncreaseBy2Within10DaysOfChristmas(int sellIn)
        {
            // Arrange

            InventoryItem systemUnderTest = new ChristmasCracker(sellIn, 8);

            // Act

            systemUnderTest.MatureOvernight();

            // Assert

            systemUnderTest.SellIn.ShouldBe(sellIn - 1);
            systemUnderTest.Quality.ShouldBe(10);
        }

        [Theory]
        [InlineData(12)]
        [InlineData(14)]
        [InlineData(16)]
        public void QualityIncreaseBy1Over10DaysFromChristmas(int sellIn)
        {
            // Arrange

            InventoryItem systemUnderTest = new ChristmasCracker(sellIn, 9);

            // Act

            systemUnderTest.MatureOvernight();

            // Assert

            systemUnderTest.SellIn.ShouldBe(sellIn - 1);
            systemUnderTest.Quality.ShouldBe(10);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-5)]
        [InlineData(-10)]
        public void QualityShouldBeZeroAfterChristmas(int sellIn)
        {
            // Arrange

            InventoryItem systemUnderTest = new ChristmasCracker(sellIn, 10);

            // Act

            systemUnderTest.MatureOvernight();

            // Assert

            systemUnderTest.SellIn.ShouldBe(sellIn - 1);
            systemUnderTest.Quality.ShouldBe(0);
        }

        [Fact]
        public void SellInShouldNotChangeAtMinValue()
        {
            // Arrange

            InventoryItem systemUnderTest = new ChristmasCracker(int.MinValue, 1);

            // Act

            systemUnderTest.MatureOvernight();

            // Assert

            systemUnderTest.SellIn.ShouldBe(int.MinValue);
        }

        [Theory]
        [InlineData(-4)]
        [InlineData(-20)]
        [InlineData(-50)]
        [InlineData(int.MinValue)]
        public void QualityShouldNeverBeNegative(int quality)
        {
            // Arrange

            InventoryItem systemUnderTest = new ChristmasCracker(1, quality);

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

            InventoryItem systemUnderTest = new ChristmasCracker(1, quality);

            // Act

            systemUnderTest.MatureOvernight();

            // Assert

            systemUnderTest.Quality.ShouldBe(50);
        }
    }
}
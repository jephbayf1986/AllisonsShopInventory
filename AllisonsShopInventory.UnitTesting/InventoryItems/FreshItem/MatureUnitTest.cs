﻿using AllisonsShopInventory.InventoryItems;
using Shouldly;
using Xunit;

namespace AllisonsShopInventory.UnitTesting.InventoryItems.FreshItemUnitTests
{
    public class MatureUnitTest
    {
        // For Range between 0 and 50
        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 10)]
        [InlineData(40, 50)]
        public void ShouldDecreaseQualityBy2BeforeSellby(int sellIn, int quality)
        {
            // Arrange

            InventoryItem systemUnderTest = new FreshItem(sellIn, quality);

            // Act

            systemUnderTest.MatureOvernight();

            // Assert

            systemUnderTest.SellIn.ShouldBe(sellIn - 1);
            systemUnderTest.Quality.ShouldBe(quality - 2);
        }

        // For Range between 0 and 50
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(40)]
        public void ShouldDecreaseQualityAtDoubleSpeedAtNegative(int positiveSellIn)
        {
            // Arrange

            InventoryItem systemUnderTestPositive = new FreshItem(positiveSellIn, 10);
            InventoryItem systemUnderTestNegative = new FreshItem(-positiveSellIn, 10);

            // Act

            systemUnderTestPositive.MatureOvernight();
            systemUnderTestNegative.MatureOvernight();

            // Assert

            int PositiveDecrease = 10 - systemUnderTestPositive.Quality;
            int NegativeDecrease = 10 - systemUnderTestNegative.Quality;

            NegativeDecrease.ShouldBe(PositiveDecrease * 2);
        }

        [Fact]
        public void SellInShouldNotChangeAtMinValue()
        {
            // Arrange

            InventoryItem systemUnderTest = new FreshItem(int.MinValue, 1);

            // Act

            systemUnderTest.MatureOvernight();

            // Assert

            systemUnderTest.SellIn.ShouldBe(int.MinValue);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-20)]
        [InlineData(-50)]
        [InlineData(int.MinValue)]
        public void QualityShouldNeverBeNegative(int quality)
        {
            // Arrange

            InventoryItem systemUnderTest = new FreshItem(1, quality);

            // Act

            systemUnderTest.MatureOvernight();

            // Assert

            systemUnderTest.Quality.ShouldBe(0);
        }

        [Theory]
        [InlineData(52)]
        [InlineData(80)]
        [InlineData(int.MaxValue)]
        public void QualityShouldNeverBeOver50(int quality)
        {
            // Arrange

            InventoryItem systemUnderTest = new FreshItem(1, quality);

            // Act

            systemUnderTest.MatureOvernight();

            // Assert

            systemUnderTest.Quality.ShouldBe(50);
        }
    }
}
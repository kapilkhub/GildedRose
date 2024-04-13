using GildedRoseKata;
using System.Collections.Generic;
using Xunit;

namespace GildedRoseTests.BackstagePassesTests
{
	public class BackstagePassesTest
	{
		/// <summary>
		/// test for quality when sell in days are less than zero
		/// </summary>
		[Fact]
		public void quality_should_be_zero_after_negative_sellin_days()
		{
			// Arrange
			var items = new List<Item>
			{
				new Item() { Name = RoseName.BackstagePasses, Quality = 10, SellIn = -1 }
			};
			GildedRoseStub _gildedRose = new GildedRoseStub(items);

			// Act
			_gildedRose.UpdateQuality();

			// Assert
			Assert.Equal(0, _gildedRose.Items[0].Quality);
		}


		/// <summary>
		/// test for quality when sell in days are positive
		/// </summary>
		/// <param name="sellInDays"></param>
		/// <param name="initialQuality"></param>
		/// <param name="expectedQuality"></param>
		[Theory]
		[InlineData(11, 10, 11)] // sell in days >10
		[InlineData(11, 50, 50)] // sell in days >10 , but quality is already 50
		[InlineData(10, 10, 12)] // sell in days <=10
		[InlineData(10, 50, 50)] // sell in days <=10 , but quality is already 50
		[InlineData(5, 10, 13)] //sell in days <=5
		[InlineData(5, 50, 50)] //sell in days <=5, but quality is already 50
		public void quality_increase_test(int sellInDays, int initialQuality, int expectedQuality)
		{
			// Arrange
			var items = new List<Item>
			{
				new Item() { Name = RoseName.BackstagePasses, Quality = initialQuality, SellIn = sellInDays }
			};
			GildedRoseStub _gildedRose = new GildedRoseStub(items);

			// Act
			_gildedRose.UpdateQuality();

			//Assert
			Assert.Equal(expectedQuality, _gildedRose.Items[0].Quality);
			Assert.Equal(sellInDays-1, _gildedRose.Items[0].SellIn);

		}
	}
}

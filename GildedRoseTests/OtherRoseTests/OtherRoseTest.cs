using GildedRoseKata;
using System.Collections.Generic;
using Xunit;

namespace GildedRoseTests.OtherRoseTests
{
	public class OtherRoseTest
	{
		/// <summary>
		/// quality test for other rose types for positive sell in days, 
		/// quality degrades one point at a time 
		/// </summary>
		/// <param name="roseName"></param>
		/// <param name="currentQuality"></param>
		/// <param name="expectedQuality"></param>
		[Theory]
		[InlineData(RoseName.Dexterity, 7,  6)]
		[InlineData(RoseName.Mongoose, 7, 6)]
		[InlineData(RoseName.Conjured, 7, 6)]
		public void other_rose_qualty_test_for_positive_sellin_days(string roseName, int currentQuality, int expectedQuality)
		{
			var items = new List<Item>
			{
				new Item() { Name = roseName, Quality = currentQuality, SellIn = 1 }
			};
			GildedRoseStub _gildedRose = new GildedRoseStub(items);

			_gildedRose.UpdateQuality();

			Assert.Equal(expectedQuality, _gildedRose.Items[0].Quality);
		}



		/// <summary>
		/// quality test for other rose types for positive sell in days, 
		/// quality degrades two points at a time 
		/// </summary>
		/// <param name="roseName"></param>
		/// <param name="currentQuality"></param>
		/// <param name="expectedQuality"></param>
		[Theory]
		[InlineData(RoseName.Dexterity, 7, 5)]
		[InlineData(RoseName.Mongoose, 4, 2)]
		[InlineData(RoseName.Conjured, 9, 7)]
		public void other_rose_qualty_test_for_zero_or_less_sellin_days(string roseName, int currentQuality, int expectedQuality)
		{
			var items = new List<Item>
			{
				new Item() { Name = roseName, Quality = currentQuality, SellIn = -1 },
				new Item() { Name = roseName, Quality = currentQuality, SellIn = 0 }
			};
			GildedRoseStub _gildedRose = new GildedRoseStub(items);

			_gildedRose.UpdateQuality();

			Assert.Equal(expectedQuality, _gildedRose.Items[0].Quality);
			Assert.Equal(expectedQuality, _gildedRose.Items[1].Quality);
		}
	}
}

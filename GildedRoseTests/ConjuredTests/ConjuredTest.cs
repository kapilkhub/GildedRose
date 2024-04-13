using GildedRoseKata;
using System.Collections.Generic;
using Xunit;

namespace GildedRoseTests.ConjuredTests
{
	public class ConjuredTest
	{
		/// <summary>
		/// quality test for Conjured rose types for positive sell in days, 
		/// quality degrades one point at a time 
		/// Conjured quality decays twice as fast as normal items
		/// </summary>
		/// <param name="roseName"></param>
		/// <param name="currentQuality"></param>
		/// <param name="expectedQuality"></param>
		[Theory]
		[InlineData(RoseName.Conjured, 7, 5)]
		[InlineData(RoseName.Conjured, 10, 8)]

		public void conjured_rose_qualty_test_for_positive_sellin_days(string roseName, int currentQuality, int expectedQuality)
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
		/// quality test for Conjured rose types for positive sell in days, 
		/// quality degrades two points at a time 
		/// Conjured quality decays twice as fast as normal items
		/// </summary>
		/// <param name="roseName"></param>
		/// <param name="currentQuality"></param>
		/// <param name="expectedQuality"></param>
		[Theory]
		[InlineData(RoseName.Conjured, 7, 3)]
		[InlineData(RoseName.Conjured, 10, 6)]
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

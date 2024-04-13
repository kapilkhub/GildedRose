using GildedRoseKata;
using Xunit;

namespace GildedRoseTests.AgedBrieTests
{
	internal class AgedBrieData : TheoryData<AgedBrie>
	{
		public AgedBrieData()
		{
			Add(new AgedBrie() { Item = new Item { Name = RoseName.AgedBrie, Quality = 10, SellIn = 15 }, ExpectedQuality = 11, ExpectedSellIn = 14 });
			Add(new AgedBrie() { Item = new Item { Name = RoseName.AgedBrie, Quality = 50, SellIn = 7 }, ExpectedQuality = 50, ExpectedSellIn = 6 });
			Add(new AgedBrie() { Item = new Item { Name = RoseName.AgedBrie, Quality = 2, SellIn = 0 }, ExpectedQuality = 4, ExpectedSellIn = -1 });
		}
	}

	public class AgedBrie
	{
		public required Item Item { get; set; }
		public required int ExpectedQuality { get; set; }
		public required int ExpectedSellIn { get; set; }
	}
}

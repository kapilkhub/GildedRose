using GildedRoseKata;
using Xunit;

namespace GildedRoseTests.AgedBrieTests
{
	internal class AgedBrieData : TheoryData<AgedBrie>
	{
		public AgedBrieData()
		{
			Add(new AgedBrie() { Item = new Item { Name = "Aged Brie", Quality = 10, SellIn = 15 }, ExpectedQuality = 11, ExpectedSellIn = 14 });
			Add(new AgedBrie() { Item = new Item { Name = "Aged Brie", Quality = 50, SellIn = 7 }, ExpectedQuality = 50, ExpectedSellIn = 6 });
		}
	}

	public class AgedBrie
	{
		public Item Item { get; set; }
		public int ExpectedQuality { get; set; }
		public int ExpectedSellIn { get; set; }
	}
}

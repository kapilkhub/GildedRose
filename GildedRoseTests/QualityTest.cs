using GildedRoseKata;
using System.Linq;
using Xunit;

namespace GildedRoseTests
{
	public class QualityTest
	{
		public QualityTest()
		{
			Program.Main(new string[] { "30" });
		}

		[Fact]
		public void quality_of_items_cannot_be_negative()
		{
			var negativeQuality = Program.Items.Any(item => item.Quality < 0);
			Assert.False(negativeQuality);
		}

		[Fact]
		public void quality_of_items_cannot_be_more_than_50()
		{
			var quality = Program.Items.Where(item => !item.Name.StartsWith("Sulfuras")).Any(item => item.Quality > 50);
			Assert.False(quality);
		}

		[Fact]
		public void quality_of_Sulfuras_should_always_be_80()
		{
			var quality = Program.Items.Any(item => item.Name.StartsWith("Sulfuras") && item.Quality!=80);
			Assert.False(quality);
		}
	}
}

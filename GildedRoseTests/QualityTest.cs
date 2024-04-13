using GildedRoseKata;
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
			Program.Items
		}
	}
}

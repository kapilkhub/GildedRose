using GildedRoseKata;
using System.Collections.Generic;
using Xunit;

namespace GildedRoseTests.AgedBrieTests
{
    public class AgedBrieTest
    {
		/// <summary>
		/// "Aged Brie" actually increases in Quality the older it gets
		/// "Aged Brie" quality does not exceed 50
		/// </summary>
		/// <param name="data"></param>
		[Theory]
        [ClassData(typeof(AgedBrieData))]
        public void aged_brie_quality_increases_as_older_it_gets_but_never_goes_beyond_50(AgedBrie data)
        {
            //Arange 
            var Items = new List<Item>
            {
                data.Item
            };
            GildedRoseStub gildedRose = new GildedRoseStub(Items);

            //Act
            gildedRose.UpdateQuality();

            //Assert Quality
            Assert.Equal(data.ExpectedQuality, gildedRose.Items[0].Quality);
            
            //Assert sell in
            Assert.Equal(data.ExpectedSellIn, gildedRose.Items[0].SellIn);
			
		}
    }


}

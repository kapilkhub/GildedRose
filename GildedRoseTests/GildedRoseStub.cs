using GildedRoseKata;
using System.Collections.Generic;

namespace GildedRoseTests
{
    /// <summary>
    /// This class is only for testing 
    /// As we do not want to change the visibility of items property of GildedRose class just for the sake of testing
    /// </summary>
    public class GildedRoseStub : GildedRose
	{
        public List<Item> Items;
        public GildedRoseStub(List<Item> items) : base(items)
        {
            Items = items;
        }
    }


}

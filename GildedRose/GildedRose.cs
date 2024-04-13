using System.Collections.Generic;
using GildedRoseKata.Extensions;

namespace GildedRoseKata
{
	public class GildedRose
    {
		readonly IList<Item>  Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        /// <summary>
        /// Update Quality for Item
        /// </summary>
        public void UpdateQuality()
        {
            foreach (Item item in Items)
            {
                switch (item.Name)
                {
                    case RoseName.Dexterity:
                    case RoseName.Mongoose:
                        item.ProcessOtherRoseQuality();
						break;
					case RoseName.Conjured:
                        item.ProcessConjuredQuality();
						break;
                    case RoseName.AgedBrie:
						item.ProcessAgedBrieQuaity();
						break;
                    case RoseName.BackstagePasses:
                        item.ProcessBackstagePassesQuality();
						break;
                    default:
                        break;
                }
			}
        }
       
      
        
    }
}

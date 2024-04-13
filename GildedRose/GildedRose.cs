using System.Collections.Generic;

namespace GildedRoseKata
{
	public class GildedRose
    {
		readonly IList<Item>  Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {

            foreach (Item item in Items)
            {
                switch (item.Name)
                {
                    case RoseName.Dexterity:
                    case RoseName.Mongoose:
                    case RoseName.Conjured:
                        UpdateOtherRoseQuality(item);
						item.SellIn--;
						break;
                    case RoseName.AgedBrie:
						UpdateAgedBrieQuaity(item);
						item.SellIn--;
						break;
                    case RoseName.BackstagePasses:
                        UpdateBackstagePassQuality(item);
						item.SellIn--;
						break;
                    default:
                        break;
                }
			
			}
        }


        private void UpdateOtherRoseQuality(Item item)
        {
            if (item.SellIn > 0)
            {
				item.Quality -= 1;
			}
            else 
            {
                item.Quality -= 2;
            }
		    item.Quality = item.Quality < 0 ? 0 : item.Quality;

		}

        private void UpdateAgedBrieQuaity(Item item) 
        {
            if (item.SellIn <= 0)
            {
                item.Quality += 2;
            }
            else
            {
				item.Quality++;
			}

            item.Quality  = item.Quality > 50 ? 50 : item.Quality;
            

		}

        private void UpdateBackstagePassQuality(Item item)
        {
			
			if (item.SellIn > 0)
            {
                if (item.SellIn > 10)
                {
                    item.Quality++;
                }
                else if (item.SellIn <= 10 && item.SellIn > 5)
                {
                    item.Quality += 2;
                }
                else if (item.SellIn <= 5) 
                {
					item.Quality += 3;
				}
			}
            else 
            {
                item.Quality = 0;
            }

			item.Quality = item.Quality>50 ?50: item.Quality;
			
		}
        
    }
}

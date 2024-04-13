using System.Collections.Generic;

namespace GildedRoseKata
{
	public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {

            foreach (Item item in Items)
            {
                if (item.Name != RoseName.AgedBrie && item.Name != RoseName.BackstagePasses)
                {
					if (item.Quality > 0 && item.Name != RoseName.Sulfuras)
					{
						item.Quality = item.Quality - 1;
					}
				}
                else
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;

                        if (item.Name == RoseName.BackstagePasses)
                        {
							if (item.SellIn < 11 && item.Quality < 50)
							{
								item.Quality = item.Quality + 1;
							}

							if (item.SellIn < 6 && item.Quality < 50)
							{
								item.Quality = item.Quality + 1;
							}
						}
                    }
                }

                if (item.Name != RoseName.Sulfuras)
                {
                    item.SellIn = item.SellIn - 1;
                }

                if (item.SellIn < 0)
                {
                    if (item.Name != RoseName.AgedBrie)
                    {
                        if (item.Name != RoseName.BackstagePasses)
                        {
							if (item.Quality > 0 && item.Name != RoseName.Sulfuras)
							{
								item.Quality = item.Quality - 1;
							}
						}
                        else
                        {
                            item.Quality = 0;
                        }
                    }
                    else
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }
                }
            }
        }
    }
}

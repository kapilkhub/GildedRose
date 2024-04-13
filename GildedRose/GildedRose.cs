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

            foreach (var item in Items)
            {
                
            }

            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != RoseName.AgedBrie && Items[i].Name != RoseName.BackstagePasses)
                {
					if (Items[i].Quality > 0 && Items[i].Name != RoseName.Sulfuras)
					{
						Items[i].Quality = Items[i].Quality - 1;
					}
				}
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;

                        if (Items[i].Name == RoseName.BackstagePasses)
                        {
							if (Items[i].SellIn < 11 && Items[i].Quality < 50)
							{
								Items[i].Quality = Items[i].Quality + 1;
							}

							if (Items[i].SellIn < 6 && Items[i].Quality < 50)
							{
								Items[i].Quality = Items[i].Quality + 1;
							}
						}
                    }
                }

                if (Items[i].Name != RoseName.Sulfuras)
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name != RoseName.AgedBrie)
                    {
                        if (Items[i].Name != RoseName.BackstagePasses)
                        {
							if (Items[i].Quality > 0 && Items[i].Name != RoseName.Sulfuras)
							{
								Items[i].Quality = Items[i].Quality - 1;
							}
						}
                        else
                        {
                            Items[i].Quality = 0;
                        }
                    }
                    else
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }
                }
            }
        }
    }
}

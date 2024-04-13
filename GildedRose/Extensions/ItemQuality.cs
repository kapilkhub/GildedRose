namespace GildedRoseKata.Extensions
{
	public static class ItemQuality
	{

		public static void ProcessOtherRoseQuality(this Item item)
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
			item.SellIn--;
		}
		public static void ProcessConjuredQuality(this Item item)
		{
			if (item.SellIn > 0)
			{
				item.Quality -= 2;
			}
			else
			{
				item.Quality -= 4;
			}
			item.Quality = item.Quality < 0 ? 0 : item.Quality;
			item.SellIn--;
		}

		public static void ProcessAgedBrieQuaity(this Item item)
		{
			if (item.SellIn <= 0)
			{
				item.Quality += 2;
			}
			else
			{
				item.Quality++;
			}

			item.Quality = item.Quality > 50 ? 50 : item.Quality;
			item.SellIn--;
		}

		public static void ProcessBackstagePassesQuality(this Item item)
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

			item.Quality = item.Quality > 50 ? 50 : item.Quality;
			item.SellIn--;
		}
	}
}

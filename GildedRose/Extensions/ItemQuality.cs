namespace GildedRoseKata.Extensions
{
	internal static class ItemQuality
	{
		/// <summary>
		/// process quality for other roses
		/// </summary>
		/// <param name="item"></param>
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

		/// <summary>
		/// process quality for Conjured Rose Type
		/// </summary>
		/// <param name="item"></param>
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

		/// <summary>
		/// Process Quality for Aged Brie
		/// </summary>
		/// <param name="item"></param>
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

		/// <summary>
		/// Process Quality for Backstage Passes
		/// </summary>
		/// <param name="item"></param>
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

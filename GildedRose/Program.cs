using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
	public class Program
	{
		public static IList<Item> Items;

		public static void Main(string[] args)
		{
			Console.WriteLine("OMGHAI!");

			Items = new List<Item>{
				new() {Name = RoseName.Dexterity, SellIn = 10, Quality = 20},
				new() {Name = RoseName.AgedBrie, SellIn = 2, Quality = 0},
				new() {Name = RoseName.Mongoose, SellIn = 5, Quality = 7},
				new() {Name = RoseName.Sulfuras, SellIn = 0, Quality = 80},
				new() {Name = RoseName.Sulfuras, SellIn = -1, Quality = 80},
				new()
				{
					Name = RoseName.BackstagePasses,
					SellIn = 15,
					Quality = 20
				},
				new ()
				{
					Name = RoseName.BackstagePasses,
					SellIn = 10,
					Quality = 49
				},
				new ()
				{
					Name = RoseName.BackstagePasses,
					SellIn = 5,
					Quality = 49
				},
				// this conjured item does not work properly yet
				new () {Name =RoseName.Conjured, SellIn = 3, Quality = 6}
			};

			var app = new GildedRose(Items);


			for (var i = 0; i < 31; i++)
			{
				Console.WriteLine("-------- day " + i + " --------");
				Console.WriteLine("name, sellIn, quality");
				for (var j = 0; j < Items.Count; j++)
				{
					System.Console.WriteLine(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality);
				}
				Console.WriteLine("");
				app.UpdateQuality();
			}
		}
	}
}

using System;

namespace Oops.Game
{
	public class Player
	{
		public object Weapon { get; set; }
		public Armor Armor { get; set; }

		Player()
		{

			Weapon = new WoodenSword ();
		}

	}
}

// Things we need for a game: Player/stats, Badguys, map/levels, items, Gold, input

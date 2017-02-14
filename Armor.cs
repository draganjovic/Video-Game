using System;

namespace Oops.Game
{
	public enum ArmorType
	{
		Plate,
		Chain,
		Pants,
		Ring,
	}

	public class Armor
	{
		protected Armor(ArmorType type, int durability, int protection)
		{
			Type = type;
			Durability = durability;
			Protection = protection;
		}
		public ArmorType Type;
		public int Durability;
		public int Protection;

		public static Armor Plate
		{
			get { return new Armor(ArmorType.Plate, 100, 100); }
		}
		public static Armor Chain
		{
			get { return new Armor(ArmorType.Chain, 100, 100); }
		}
		public static Armor Pants
		{
			get { return new Armor(ArmorType.Pants, 100, 100); }
		}
	}
}


		

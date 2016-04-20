using System.Collections;
using System;

namespace Oops.Game
{
	public class Weapon
	{
		protected Weapon(int damage, int ammo, int durability)
		{
			Damage = damage;
			Ammo = ammo;
			Durability = durability;
		}
		public int Damage;
		public int Ammo;
		public int Durability;
	}

	class WoodenSword : Weapon
	{
		public WoodenSword() // The player will start off with this weapon by default
			: base(100, 0, 100)
		{
			Damage = 20;
			Ammo = 0;
			Durability = 50;
		}
		void Attack() // This function will allow user to attack using their sword
		{

		}

	}
	class SteelSword : Weapon
	{
		public SteelSword()
			: base(100, 0, 100)
		{
			Damage = 40;
			Ammo = 0;
			Durability = 50;
		}
		void Attack() // This function will allow user to attack using their sword
		{
			
		}


	}
	class Pistol : Weapon
	{
		public Pistol()
			: base(100, 100, 100)
		{
			Damage = 60;
			Ammo = 50;
			Durability = 70;
		}
		void Reload() 
		{
			
		}
	}
	class Rock : Weapon
	{
		public Rock()
			: base(100, 0, 100)
		{
			Damage = 10;
			Ammo = 0; // Rock is an object, it does not have ammo.

			Durability = 20; // This is based on how many times you use the rock
							// Using it 20+ times will cause the rock to break
		}
		void Throw_Rock () // Function that will control throwing rock at opponent
		{
			
		} 
		void Pickup_Rock() // Function that will let user pick up rock after it is dropped
		{
			
		} 
	}
	class Knife : Weapon
	{
		public Knife()
			: base(100, 0, 100)
		{
			Damage = 30;
			Ammo = 0; // Knife is an object, it does not have ammo.
			Durability = 50;

		}
		void Stab() // Function that will control stabbing your opponent
		{
			
		} 
	}
	class Shotgun : Weapon
	{
		public Shotgun()
			: base(100, 100, 100)
		{
			Damage = 80;
			Ammo = 20;
			Durability = 70;
		}
		void Reload() // Function that will control reloading your weapon
		{
			
		}
	}
}

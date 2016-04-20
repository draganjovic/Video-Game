using System;

namespace Oops
{
	public class DefaultPlayer
	{
		protected DefaultPlayer(int head, int arm, int leg, int eye, int nose, int ear, int mouth, int foot, int hand)
		{
			Head = head;
			Arm = arm;
			Leg = leg;
			Eye = eye;
			Nose = nose;
			Ear = ear;
			Mouth = mouth;
			Foot = foot;
			Hand = hand;
		}
		public int Head;
		public int Arm;
		public int Leg;
		public int Eye;
		public int Nose;
		public int Ear;
		public int Mouth;
		public int Foot;
		public int Hand;
	}
	class Niko : DefaultPlayer
	{
		public Niko()
			: base(1, 2, 2, 2, 1, 2, 1, 2, 2)
		{
			Head = 1;
			Arm = 2;
			Leg = 1;
			Eye = 1;
			Nose = 1;
			Mouth = 1;
			Foot = 2;
			Hand = 1;
		}
		void Walk() {} // Control how character walks. Left, Right, Forward, Backwards
		void Jump() {} // Allow character to jump
		void DoubleJump() {} // Allow character to jump twice
		void Run() {} // Allow for character to run in short bursts
		void TakeOutWeapon() {} // Allow character to take out primary weapon
		void PutAwayWeapon() {} // Allow character to put weapon away
	}
	class Jerry : DefaultPlayer
	{
		public Jerry()
			: base(1, 2, 2, 2, 1, 2, 1, 2, 2)
		{
			Head = 2;
			Arm = 4;
			Leg = 1;
			Eye = 4;
			Nose = 0;
			Mouth = 1;
			Foot = 2;
			Hand = 2;
		}
		void Walk() {} // Control how character walks. Left, Right, Forward, Backwards
		void Run() {} // Allow for character to run in short burts
		void TakeOutWeapon() {} // Allow character to take out primary weapon
		void PutAwayWeapon() {} // Allow character to put weapon away

		// This character can not jump or double jump, because he only has one leg.
	}
}


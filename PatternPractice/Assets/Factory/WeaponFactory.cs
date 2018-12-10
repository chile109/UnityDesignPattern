using System.Collections;
using System.Collections.Generic;

namespace SimpleFactory
{
	public class GunFactory
	{
		public Weapon CreateWeapon(string style) {
			Weapon weapon = null;
			switch (style)
			{
				case "Gun":
					weapon = new HandGun();
					break;
			}
			return weapon;
		}
	}
}

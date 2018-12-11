using System.Collections;
using System.Collections.Generic;

namespace SimpleFactory
{
	public class GunFactory
	{
		public Weapon CreateWeapon(WeaponType style) {
			Weapon weapon = null;
			switch (style)
			{
				case WeaponType.Light:
					weapon = new HandGun();
					break;
				case WeaponType.Heavy:
					weapon = new HandGun();
					break;
			}
			return weapon;
		}
	}

	public enum WeaponType
	{
		Light,
		Heavy
	}
}

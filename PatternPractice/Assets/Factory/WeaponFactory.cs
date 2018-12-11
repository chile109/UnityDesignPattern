using System.Collections;
using System.Collections.Generic;

namespace SimpleFactory
{
	public class GunFactory
	{
		//detemine which weapon to create
		public Weapon CreateWeapon(WeaponType style) {
			Weapon weapon = null;
			switch (style)
			{
				case WeaponType.Light:
					weapon = new HandGun();
					break;
				case WeaponType.Heavy:
					weapon = new ShotGun();
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactory
{
	public class GunFactory: MonoBehaviour
	{
		//detemine which weapon to create
		public GameObject CreateWeapon(WeaponType style) {
			GameObject weapon = new GameObject();
			switch (style)
			{
				case WeaponType.Light:
					weapon.name = "HandGun";
					weapon.AddComponent<HandGun>();
					break;
				case WeaponType.Heavy:
					weapon.name = "ShotGun";
					weapon.AddComponent<ShotGun>();
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

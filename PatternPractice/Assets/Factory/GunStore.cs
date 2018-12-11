using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactory
{
	public class GunStroe
	{
		private readonly GunFactory _factory;

		public GunStroe(GunFactory factory)
		{
			this._factory = factory;
		}

		public Weapon BuyWeapon(WeaponType type)
		{
			//The main create logic is striped to factory class
			Weapon weapon = _factory.CreateWeapon(type);
			weapon.Prepare();
			
			return weapon;
		}
	}

}


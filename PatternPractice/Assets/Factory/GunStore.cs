using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactory
{
	public class GunStroe : MonoBehaviour
	{
		private readonly GunFactory _factory = new GunFactory();

		public GunStroe(GunFactory factory)
		{
			this._factory = factory;
		}

		public Weapon BuyWeapon(String type)
		{
			Weapon weapon = _factory.CreateWeapon("Gun");
			weapon.Prepare();
			weapon.Shot();

			return weapon;
		}

		
	}

}


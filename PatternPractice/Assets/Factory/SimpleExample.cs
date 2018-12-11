using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactory
{
	public class SimpleExample : MonoBehaviour
	{
		public WeaponType WhatYouBuy;
		
		// Use this for initialization
		void Start()
		{
			GunFactory _gunFactory = new GunFactory();
			GunStroe _gunStroe = new GunStroe(_gunFactory);

			_gunStroe.BuyWeapon(WhatYouBuy).Shot();
		}
	}
}

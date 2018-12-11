using UnityEngine;

namespace Factory.SimpleFactory
{
	public class SimpleExample : MonoBehaviour
	{
		public WeaponType WhatYouBuy;
		
		// Use this for initialization
		void Start()
		{
			GunFactory _gunFactory = new GunFactory();
			GunStore _gunStroe = new GunStore(_gunFactory);

			var equipment = _gunStroe.BuyWeapon(WhatYouBuy);
			equipment.GetComponent<Weapon>().Shot();
		}
	}
}

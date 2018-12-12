using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Factory.FactoryMethod
{
	public class FactoryExample : MonoBehaviour
	{
		private Factory _Store;
		public PartType WhatYouBuy;
		
		/// <summary>
		/// Only need to change factory subclass to get what product you want without change the use of client.
		/// Generally, one factory handle their own product. You need to create new store with new product.
		/// </summary>
		void Start()
		{
			
			//_Store = new GunStore();
			_Store = new BowStore();
			
			var product = _Store.CreateWeapon(WhatYouBuy);
			product.GetComponent<WeaponPart>().Prepare();
		}
	}

}

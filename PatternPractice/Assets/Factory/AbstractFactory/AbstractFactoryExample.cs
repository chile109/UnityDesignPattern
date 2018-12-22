using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Factory.AbstractFactory
{
	public class AbstractFactoryExample : MonoBehaviour
	{
		private WeaponStore store;
		// Use this for initialization
		void Start()
		{
			store = new FirearmStore();
			//store = new ColdSteelStore();
			store.OrderWeapon();
		}

	}
}

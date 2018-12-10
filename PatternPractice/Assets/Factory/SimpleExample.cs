using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactory
{
	public class SimpleExample : MonoBehaviour
	{
		// Use this for initialization
		void Start()
		{
			GunFactory _gunFactory = new GunFactory();
			GunStroe _gunStroe = new GunStroe(_gunFactory);

			_gunStroe.BuyWeapon("Gun");

		}
	}
}

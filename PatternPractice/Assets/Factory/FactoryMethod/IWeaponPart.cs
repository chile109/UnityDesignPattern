using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Factory.FactoryMethod
{
	public interface WeaponPart
	{
		void Prepare();	//Action of providing weapon
	}

	public class Gun : MonoBehaviour, WeaponPart
	{
		public void Prepare()
		{
			Debug.Log("Equiped Gun!");
		}

	}
	
	public class Bullet : MonoBehaviour, WeaponPart
	{
		public void Prepare()
		{
			Debug.Log("Get Bullet!");
		}
	}
	
	public class Bow : MonoBehaviour, WeaponPart
	{
		public void Prepare()
		{
			Debug.Log("Equiped Bow!");
		}

	}
	
	public class Arrow : MonoBehaviour, WeaponPart
	{
		public void Prepare()
		{
			Debug.Log("Get Arrow!");
		}
	}

}

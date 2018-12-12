using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Factory.FactoryMethod
{
	public enum PartType
	{
		Launcher,
		Projectile
	}
	
	//lets a class defer instantiation to child classes. 
	public abstract class Factory: MonoBehaviour
	{
		public abstract GameObject CreateWeapon(PartType style);
	}

	public class GunStore: Factory
	{
		public override GameObject CreateWeapon(PartType style) {
			GameObject weaponpart = new GameObject();
			switch (style)
			{
				case PartType.Launcher:
					weaponpart.name = "Gun";
					weaponpart.AddComponent<Gun>();
					break;
				case PartType.Projectile:
					weaponpart.name = "Bullet";
					weaponpart.AddComponent<Bullet>();
					break;
			}
			return weaponpart;
		}
	}
	
	public class BowStore: Factory
	{
		public override GameObject CreateWeapon(PartType style) {
			GameObject weaponpart = new GameObject();
			switch (style)
			{
				case PartType.Launcher:
					weaponpart.name = "Bow";
					weaponpart.AddComponent<Bow>();
					break;
				case PartType.Projectile:
					weaponpart.name = "Arrow";
					weaponpart.AddComponent<Arrow>();
					break;
			}
			return weaponpart;
		}
	}
}


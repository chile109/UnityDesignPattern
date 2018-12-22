using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Factory.AbstractFactory
{

	//lets a class defer instantiation to child classes. 
	public abstract class WeaponStore: MonoBehaviour
	{
		public Launcher Gun;
		public Projectile Bullet;
		public WeaponFactory factory;
		
		public void OrderWeapon()
		{
			Gun.Reload(Bullet);
		}
	}

	public class FirearmStore: WeaponStore
	{
		public FirearmStore()
		{
			factory = new FirearmFactory();
			Gun = factory.CreateLauncher();
			Bullet = factory.CreateProjectile();
		}
	}
	
	public class ColdSteelStore: WeaponStore
	{
		public ColdSteelStore()
		{
			factory = new ColdSteelFactory();
			Gun = factory.CreateLauncher();
			Bullet = factory.CreateProjectile();
		}
	}
}


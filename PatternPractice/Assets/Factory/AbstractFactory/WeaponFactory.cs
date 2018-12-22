using System.Collections;
using System.Collections.Generic;
using Factory.FactoryMethod;
using UnityEngine;
using UnityEngine.Rendering;

namespace Factory.AbstractFactory
{
	public interface WeaponFactory
	{
		Launcher CreateLauncher();
		Projectile CreateProjectile();
	}

	public class FirearmFactory : WeaponFactory
	{
		public Launcher CreateLauncher()
		{
			return new ShotGun();
		}

		public Projectile CreateProjectile()
		{
			return new Ammo();
		}
	}
	
	public class ColdSteelFactory : WeaponFactory
	{
		public Launcher CreateLauncher()
		{
			return new XBow();
		}

		public Projectile CreateProjectile()
		{
			return new Arrow();
		}
	}
}

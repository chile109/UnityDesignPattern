using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

namespace Factory.AbstractFactory
{
	public abstract class Launcher: MonoBehaviour
	{
		public String magazine = "";

		public abstract void Reload(Projectile projectile);
	}

	public abstract class Projectile
	{
		public string name = "";
	}

	public class ShotGun : Launcher
	{
		public override void Reload(Projectile projectile)
		{
			var instance = new GameObject().AddComponent<ShotGun>();
			instance.name = this.GetType().Name;
			instance.magazine = projectile.name;
		}
	}
	
	public class XBow : Launcher
	{
		public override void Reload(Projectile projectile)
		{
			var instance = new GameObject().AddComponent<Launcher>();
			instance.name = this.GetType().Name;
			instance.magazine = projectile.name;
		}
	}

	public class Ammo : Projectile
	{
		public Ammo()
		{
			name = "Ammo";
		}
	}
	
	public class Arrow : Projectile
	{
		public Arrow()
		{
			name = "Arrow";
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactory
{
	public interface Weapon
	{
		void Prepare();
		void Shot();
	}

	public class HandGun : Weapon
	{
		public virtual void Prepare()
		{
			Debug.Log("Making HandGun!");
		}

		public virtual void Shot()
		{
			Debug.Log("Pom!");
		}
	}
	
}

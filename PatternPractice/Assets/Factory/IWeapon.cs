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
		}

		public virtual void Shot()
		{
		}
	}
	
}

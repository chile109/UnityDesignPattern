﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactory
{
	public interface Weapon
	{
		void Prepare();	//Action of providing weapon
		void Shot();	//Action of using weapon
	}

	public class HandGun : Weapon
	{
		public void Prepare()
		{
			Debug.Log("Making HandGun!");
		}

		public void Shot()
		{
			Debug.Log("Pew!");
		}
	}
	
	public class ShotGun : Weapon
	{
		public void Prepare()
		{
			Debug.Log("Making ShotGun!");
		}

		public void Shot()
		{
			Debug.Log("Boom!");
		}
	}
	
}

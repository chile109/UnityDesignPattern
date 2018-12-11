using UnityEngine;

namespace Factory.SimpleFactory
{
	public interface Weapon
	{
		void Prepare();	//Action of providing weapon
		void Shot();	//Action of using weapon
	}

	public class HandGun : MonoBehaviour, Weapon
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
	
	public class ShotGun : MonoBehaviour, Weapon
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

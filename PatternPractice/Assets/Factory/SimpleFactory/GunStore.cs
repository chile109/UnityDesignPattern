using UnityEngine;

namespace Factory.SimpleFactory
{
	public class GunStore
	{
		private readonly GunFactory _factory;

		public GunStore(GunFactory factory)
		{
			this._factory = factory;
		}

		public GameObject BuyWeapon(WeaponType type)
		{
			//The main create logic is striped to factory class
			var weapon = _factory.CreateWeapon(type);
			weapon.GetComponent<Weapon>().Prepare();
			
			return weapon;
		}
	}

}


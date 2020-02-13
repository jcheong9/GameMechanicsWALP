using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class PerishableObject : LevelObject
{
	protected int health;
	protected void GetDamaged(int damage)
	{
		health = health - damage;
	}
}

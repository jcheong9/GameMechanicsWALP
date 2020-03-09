using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ObjectState
{
	idle,
	attack, 
	die
}
abstract public class PerishableObject : LevelObject
{
	protected int id;
	protected int health;
	public ObjectState myState;
	protected Rigidbody2D myRigidbody;
	protected Animator anim;
	public virtual void GetDamaged(int damage)
	{
		health = health - damage;
	}

	public void setState(ObjectState newState)
	{
		myState = newState;
	}

	public int getID()=>id;
}

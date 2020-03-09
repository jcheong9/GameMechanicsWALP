using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : PerishableObject
{
	protected int mp;
	protected float speed;
	protected int damage;
	
	// Start is called before the first frame update
	void Start()
    {
		id = 1;
		myState = ObjectState.idle;
		mySR = GetComponent<SpriteRenderer>();
		anim = GetComponent<Animator>();
		myRigidbody = GetComponent<Rigidbody2D>();
		myState = ObjectState.idle;
		speed = 4;
    }

    // Update is called once per frame
    void Update()
    {
		//position = Vector3.zero;
		UpdateAnimationAndMove();
	}

	protected void UpdateAnimationAndMove()
	{
		if (position != Vector3.zero)
		{
			MoveCharacter();
			anim.SetFloat("moveX", position.x);
			anim.SetFloat("moveY", position.y);
			anim.SetBool("moving", true);
		}
		else
		{
			anim.SetBool("moving", false);
		}
	}

	void MoveCharacter()
	{
		position.Normalize();
		myRigidbody.MovePosition(
			transform.position + position * speed * Time.deltaTime
		);
	}
	public int getDamage()
	{
		return damage;
	}
}

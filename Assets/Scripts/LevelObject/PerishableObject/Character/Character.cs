using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : PerishableObject
{
	protected int id;
	protected int mp;
	protected float speed;
	protected int damage;
	
	// Start is called before the first frame update
	void Start()
    {
		myState = ObjectState.idle;
		mySR = GetComponent<SpriteRenderer>();
		animator = GetComponent<Animator>();
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
			animator.SetFloat("moveX", position.x);
			animator.SetFloat("moveY", position.y);
			animator.SetBool("moving", true);
		}
		else
		{
			animator.SetBool("moving", false);
		}
	}
	public void GetDamaged(int damage)
	{
		health = health - damage;
	}
	void MoveCharacter()
	{
		position.Normalize();
		myRigidbody.MovePosition(
			transform.position + position * speed * Time.deltaTime
		);
	}
}

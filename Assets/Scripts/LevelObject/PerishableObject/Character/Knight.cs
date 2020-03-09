using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : Character
{
    // Start is called before the first frame update
    void Start()
    {
		myState = ObjectState.idle;
		mySR = GetComponent<SpriteRenderer>();
		anim = GetComponent<Animator>();
		myRigidbody = GetComponent<Rigidbody2D>();
		myState = ObjectState.idle;
		damage = 10;
		speed = 4;
	}

    // Update is called once per frame
    void Update()
    {
		UpdateAnimationAndMove();
		if (myState == ObjectState.attack)
		{
			StartCoroutine(hit());
		}
	}

	public IEnumerator hit()
	{
		anim.SetBool("attacking", true);
		yield return null;
		anim.SetBool("attacking", false);
		yield return new WaitForSeconds(.2f);
		myState = ObjectState.idle;
	}
}

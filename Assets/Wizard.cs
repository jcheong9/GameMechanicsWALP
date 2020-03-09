using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Character
{

	public GameObject projectile;
	ArrayList projectiles;
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
			StartCoroutine(shoot());
			Debug.Log(transform.childCount);
		}
	}
	public IEnumerator shoot()
	{
		Vector3 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector3 tempVector = target - transform.position;
		GameObject newpt = Instantiate(projectile, transform.position, Quaternion.identity);
		newpt.transform.parent = transform;
		newpt.GetComponent<Projectile>().Launch(tempVector);
		yield return new WaitForSeconds(.2f);
		myState = ObjectState.idle;
	}
}

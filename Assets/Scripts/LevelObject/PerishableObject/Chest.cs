using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : PerishableObject
{

    
    // Start is called before the first frame update
    void Start()
    {
		health = 10;
        anim = GetComponent<Animator>();
		anim.SetInteger("Health", health);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
	public override void GetDamaged(int damage)
	{
		health = health - damage;
		anim.SetInteger("Health", anim.GetInteger("Health") - damage);
		anim.SetBool("getHit", true);
		Debug.Log("got damage");
		if (anim.GetInteger("Health") <= 0)
		{
			health = 0;
			StartCoroutine("PlayAndDisappear");

		}
	}
	private IEnumerator PlayAndDisappear()
	{
		anim.Play("chestBroken");
		yield return new WaitForSeconds(anim.runtimeAnimatorController.animationClips[3].length);
		gameObject.SetActive(false); // deactivate object
	}
}

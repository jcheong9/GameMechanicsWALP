using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : PerishableObject
{

    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
		health = 100;
        anim = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public override void GetDamaged(int damage)
	{
		health = health - damage;
		anim.SetInteger("Damage", anim.GetInteger("Damage") + damage);
		Debug.Log("got damage");
		if (anim.GetInteger("Damage") >= 100)
		{
			health = 0;
			gameObject.SetActive(false);
		}
	}

}

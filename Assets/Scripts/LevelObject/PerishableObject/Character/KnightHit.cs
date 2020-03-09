using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightHit : MonoBehaviour
{
	// Start is called before the first frame update
	GameObject ownerObj;
	Knight ownerKnight;
	int damage;
    void Start()
    {
		ownerObj =  transform.parent.gameObject;
		ownerKnight = ownerObj.GetComponent<Knight>();
		damage = ownerKnight.getDamage();
	}

    // Update is called once per frame
    void Update()
    {
		
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("breakable"))
        {
            other.GetComponent<PerishableObject>().GetDamaged(damage);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HealthPack : MonoBehaviour
{

    //bool ObjectIsActive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            // TODO: If ObjectIsActive, get the object which collided with it, then heal it 
            StartCoroutine( Replenish() );
        }
    }

    IEnumerator Replenish() {
        //ObjectIsActive = false;
        gameObject.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(15f);
        gameObject.GetComponent<Renderer>().enabled = true;
        //ObjectIsActive = true;
    }
    


}

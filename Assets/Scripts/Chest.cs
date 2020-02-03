using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{

    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage()
    {
        anim.SetInteger("Damage", anim.GetInteger("Damage") + 5);
        Debug.Log(anim.GetInteger("Damage"));
        if(anim.GetInteger("Damage") > 100) {
            gameObject.SetActive(false);
        }
    }
}

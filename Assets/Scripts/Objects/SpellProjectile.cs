using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellProjectile : Projectile
{

    public SpellProjectile(Vector3 pos) : base(pos) {

    }

    // Start is called before the first frame update
    void Start()
    {
        lifetimeSeconds = lifetime;
        Debug.Log(Input.mousePosition);   
        
    }

    // Update is called once per frame
    void Update()
    {
        lifetimeSeconds -= Time.deltaTime;
        if(lifetimeSeconds <= 0) {
            Destroy(this.gameObject);
        }
    }
}

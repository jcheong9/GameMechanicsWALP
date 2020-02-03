using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public Vector3 pos;

    public Projectile(Vector3 pos)
    {
        this.pos =  pos;
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    [Header("Movement stuff")]
    public int damageAmount;
    public float moveSpeed;

    [Header("Lifetime")]
    public Vector2 directionToMove;
    public float lifetime;
    protected float lifetimeSeconds;
    public Rigidbody2D myRigidBody;

    public void Launch(Vector2 initialVel) 
    {
        myRigidBody.velocity = initialVel * moveSpeed;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(this.gameObject);
    }
}

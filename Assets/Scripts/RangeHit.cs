using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeHit : MonoBehaviour
{

    public GameObject projectile;
    public Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = gameObject.transform.position;
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 target = Camera.main.ScreenToWorldPoint( Input.mousePosition );
            Vector3 tempVector = target - transform.position;
            GameObject current = Instantiate(projectile, transform.position, Quaternion.identity);
            current.GetComponent<Projectile>().Launch(tempVector);
        }
    }
}

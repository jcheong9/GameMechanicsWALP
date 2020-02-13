using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	// Start is called before the first frame update
	public PlayerMovement myCharacter;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		myCharacter.setPositionX(Input.GetAxisRaw("Horizontal"));
		myCharacter.setPositionY(Input.GetAxisRaw("Vertical"));

	}
}

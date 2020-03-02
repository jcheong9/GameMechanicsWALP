using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	// Start is called before the first frame update
	public Character myCharacter;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		CharacterController();
	}
	public void CharacterController()
	{
		myCharacter.setPositionX(Input.GetAxisRaw("Horizontal"));
		myCharacter.setPositionY(Input.GetAxisRaw("Vertical"));
		if (Input.GetButtonDown("attack"))
		{
			myCharacter.setState(ObjectState.attack);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class LevelObject : MonoBehaviour
{
	protected Vector3 position;
	protected SpriteRenderer mySR;
	public void setPositionX(float xCoordinate)
	{
		position.x = xCoordinate;
	}
	public void setPositionY(float yCoordinate)
	{
		position.y = yCoordinate;
	}
}

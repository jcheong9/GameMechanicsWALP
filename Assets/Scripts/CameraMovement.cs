using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMovement : MonoBehaviour
{
	public Player myPlayer;
    private Transform target;
    public float smoothing;
    public Vector2 maxPosition;
    public Vector2 minPosition;

    public string countdown;
    public GameObject text;
    public Text showText;

    // Start is called before the first frame update
    void Start()
    {
		target = myPlayer.myCharacter.transform;
        Debug.Log("Starting object script...");
        StartCoroutine(countdownCo());
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(transform.position != target.position) {
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            targetPosition.x = Mathf.Clamp(targetPosition.x, minPosition.x, maxPosition.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, minPosition.y, maxPosition.y);
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }
    }

    private IEnumerator countdownCo() 
    {
        text.SetActive(true);
        countdown = "3...";
        showText.text = countdown;
        yield return new WaitForSeconds(1f);
        countdown = "2...";
        showText.text = countdown;
        yield return new WaitForSeconds(1f);
        countdown = "1...";
        showText.text = countdown;
        yield return new WaitForSeconds(1f);
        countdown = "Fight!";
        showText.text = countdown;
        yield return new WaitForSeconds(1f);
        text.SetActive(false);
    }
}

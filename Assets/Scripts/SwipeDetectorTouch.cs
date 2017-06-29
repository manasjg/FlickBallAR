using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDetectorTouch : MonoBehaviour {

	 Vector3 startPos;
    Vector3 endPos;
    Vector3 diff;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetTouch(0).phase==TouchPhase.Began)
        {
            startPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x,Input.GetTouch(0).position.y,-1));
            
        }
        if (Input.GetTouch(0).phase==TouchPhase.Ended)
        {
            endPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, -1));
            diff = endPos - startPos;
            GetComponent<BallControl2>().flick();
        }
       
       
	}
}

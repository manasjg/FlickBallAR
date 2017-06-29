using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDetector : MonoBehaviour {
    Vector3 startPos;
    Vector3 endPos;
    Vector3 diff;
    public GameObject bin;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            startPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,-1));
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            endPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -1));
            diff = endPos - startPos;
            GetComponent<Rigidbody>().isKinematic = false;
            
            GetComponent<BallControl2>().flick();
        }
       
       
	}
}

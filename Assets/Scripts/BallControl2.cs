using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl2 : MonoBehaviour {
    
    
    public void flick(float xval,float yval)
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(-xval*420,500,0));
    }
    
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl2 : MonoBehaviour {
    
    
    public void flick()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(180,500,0));
    }
    
    
}

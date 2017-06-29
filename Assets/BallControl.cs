using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float y = 1.5f;
    public float z = 1.5f;
    public void flick()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0, y, z));
    }

}

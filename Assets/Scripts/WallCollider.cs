using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollider : MonoBehaviour {

    
    
    GameObject Ball;
    Vector3 StartPos;
    int timer = 0;
    // Use this for initialization
    void Start()
    {
        Ball = GameObject.Find("Sphere");
        StartPos = Ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer == 5)
        {
            Ball.transform.position = StartPos;
            timer = 0;
            CancelInvoke("timerIncrement");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            collision.gameObject.transform.position = StartPos;
            collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            collision.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            InvokeRepeating("timerIncrement", 5, 1);
        }
    }
    void timerIncrement()
    {
        timer++;
           
    }
}

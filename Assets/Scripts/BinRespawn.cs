﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BinRespawn : MonoBehaviour {
    public Text text;
    int score=0;
    GameObject Ball;
    Vector3 StartPos;
    // Use this for initialization
    void Start()
    {
        Ball = GameObject.Find("Sphere");
        StartPos = Ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("SPhere Detected");
            other.gameObject.transform.position = StartPos;
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            score++;
            text.text = "Score: "+score.ToString();
        }
    }
}
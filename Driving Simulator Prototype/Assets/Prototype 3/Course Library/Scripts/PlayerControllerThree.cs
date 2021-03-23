﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerThree : MonoBehaviour
{
    private Rigidbody playerRB;
    public bool isOnGround = true;
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.AddForce(Vector3.up * 10, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}

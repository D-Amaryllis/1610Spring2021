﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatekeeperBehavior : MonoBehaviour
{
    public BoolData keyObj;
    private void OnTriggerEnter2D(Collider2D other)
    {
        keyObj.value = true;
        gameObject.SetActive(false);
    }
    }
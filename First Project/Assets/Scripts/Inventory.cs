﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;
        public float fuel;

        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }

        public Stuff(int bul, float fu)
        {
            bullets = bul;
            fuel = fu;
        }
        
        //Creating an Instance (an Object) of the Stuff class
        public Stuff myStuff = SingleCharacterScript.Stuff(50, 5, 5);

        public Stuff myOtherStuff = SingleCharacterScript.Stuff(50, 1.5f);

        void Start()
        {
            Debug.Log(myStuff.bullets);
        }
    }
}
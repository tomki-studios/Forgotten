﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabReading : MonoBehaviour
{
    public GameObject TabToReadPrefab;
    public GameObject TabToRead;
    public Transform canvas;
    public int Tabs = 0; 
    public bool TabCreated = false;
    public bool canRead;

    void Start() {}

    void Update() {}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "SurvivalCharacter_medium")
            canRead = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "SurvivalCharacter_medium")
        {
            canRead = false;
        }
    }
}

//Bartek A. cały skrypt stworzony przeze mnie

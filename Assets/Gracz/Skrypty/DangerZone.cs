using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerZone : MonoBehaviour
{
    public float damagePerSecond = 2f;
    public bool isGettingDamage;
    void Start() { }

    void Update() { }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "SurvivalCharacter_medium")
        {
            isGettingDamage = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.name == "SurvivalCharacter_medium")
        {
            isGettingDamage = false;
        }
    }
}

//Bartek A.

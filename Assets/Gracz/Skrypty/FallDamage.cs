using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDamage : MonoBehaviour
{
    public CharacterController controller;
    public Stats stats;
    public float minSurviveTime = 1.6f; //time you can be in air without dmg
    public float damageForSeconds = 1.5f; //damage you will get every second after minSurviveTime
    public float airTime = 0f; //actual time in air


    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (!controller.isGrounded) //when player is in air
        {
            airTime += Time.deltaTime; //setting airTime
        }
        if (controller.isGrounded) //when player isn't in air
        {
            if (airTime > minSurviveTime)  //when you pass minSurviveTime
            {
                stats.Health -= damageForSeconds * airTime; //adding dmg to player
            }
            airTime = 0f;               //reset airTime
        }
    }
}
            //Script by Daniel Grala
            
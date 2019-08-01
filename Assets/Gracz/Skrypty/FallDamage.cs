using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDamage : MonoBehaviour
{
    public CharacterController controller;
    public Stats stats;
    public float minSurviveTime = 1.6f;
    public float damageForSeconds = 1.5f;
    public float airTime = 0f;


    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (!controller.isGrounded)
        {
            airTime += Time.deltaTime;
        }
        if (controller.isGrounded)
        {
            if (airTime > minSurviveTime)
            {
                stats.Health -= damageForSeconds * airTime;
            }
            airTime = 0f;
        }
    }
}

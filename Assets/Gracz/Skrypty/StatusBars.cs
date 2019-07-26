using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusBars : MonoBehaviour
{
    public GameObject HealthBar;
    public GameObject EnergyBar;
    public GameObject HungerBar;
    public GameObject ThirstBar;

    public Stats Stats;

    void Start()
    {
        
    }

    
    void Update()
    {
        HealthBar.transform.localScale = new Vector3(Stats.Health / Stats.MaxHealth, 1, 0);
        EnergyBar.transform.localScale = new Vector3(Stats.Energy / Stats.MaxEnergy, 1, 0);
        HungerBar.transform.localScale = new Vector3(Stats.Hunger / Stats.FullHunger, 1, 0);
        ThirstBar.transform.localScale = new Vector3(Stats.Thirst / Stats.FullThirst, 1, 0);
    }
}
//Kondzio

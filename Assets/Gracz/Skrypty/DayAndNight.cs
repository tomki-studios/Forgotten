using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayAndNight : MonoBehaviour
{
    public Material MidDaySkybox;
    public Material SunriseSkybox;
    public Material SunsetSkybox;
    public Material NightSkybox;
    public Skybox PartsOfDay;
    public bool Sunrise;
    public bool Midday;
    public bool Sunset;
    public bool Night;
    public float SunriseTime = 60f;
    public float MiddayTime = 600f;
    public float SunsetTime = 60f;
    public float NightTime = 300f;

    void Start()
    {
        SetSunrise();
    }

    void Update()
    {
        SkyboxChange();
    }

    public void SkyboxChange()
    {
        if (Sunrise)
        {
            SunriseTime = SunriseTime - Time.deltaTime;
            if (SunriseTime <= 0)
            {
                Sunrise = false;
                SetMidDay();
                SunriseTime = 60f;
            }
        }
        if (Midday)
        {
            MiddayTime = MiddayTime - Time.deltaTime;
            if (MiddayTime <= 0)
            {
                Midday = false;
                SetSunset();
                MiddayTime = 600f;
            }
        }
        if (Sunset)
        {
            SunsetTime = SunsetTime - Time.deltaTime;
            if (SunsetTime <= 0)
            {
                Sunset = false;
                SetNight();
                SunsetTime = 60f;
            }
        }
        if (Night)
        {
            NightTime = NightTime - Time.deltaTime;
            if (NightTime <= 0)
            {
                Night = false;
                SetSunrise();
                NightTime = 300f;
            }
        }
    }

    private void SetSunrise()
    {
        PartsOfDay.material.CopyPropertiesFromMaterial(SunriseSkybox);
        Sunrise = true;
    }
    private void SetMidDay()
    {
        PartsOfDay.material.CopyPropertiesFromMaterial(MidDaySkybox);
        Midday = true;
    }
    private void SetSunset()
    {
        PartsOfDay.material.CopyPropertiesFromMaterial(SunsetSkybox);
        Sunset = true;
    }
    private void SetNight()
    {
        PartsOfDay.material.CopyPropertiesFromMaterial(NightSkybox);
        Night = true;
    }
}

//Bartek A. cały skrypt stworzony przeze mnie
/*Opis problemu:
 * Po przejściu pierwszej doby po końcu nocy
 * nie ładuje się Skybox poranka mimo tego, że
 * licznik jego czasu leci i bool jest true.
 * Zamiast tego zostaje Skybox nocy, a po końcu
 * licznika poranka normalnie nastaje środek dnia.
 */ 

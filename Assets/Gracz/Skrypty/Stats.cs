using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stats : MonoBehaviour {

    //Bartek A.
    public GameObject YouDiedImage;
    public GameObject RestartGameButton;
    public GameObject MainMenuButton;
    public PlayerMovement Player;
    public bool Died;

    //Timer Do Statystyk Związanych z czasem
    private float FoodTimer = 0;
    private float HealthTimer = 0;
    private float EnergyTimer = 0;
    private float HungerDamageTimer = 0;

    //Zmienne Statystyk Maksymalnych
    public float MaxHealth, MaxEnergy, FullHunger, FullThirst;

    //Zmienne Statystyk Aktywnych
    public float Health, Energy, Hunger, Thirst;

    //Zmienne Statystyk Postaci
    public int Attack, Defense, Vitality, Stamina, HungerResistance, JumpHeight;
    public float Speed;
    public bool Sprint = false;

	void Start ()
    {
        //Przypisanie Wartości Zmiennym Statystyk
        Speed = 3;
        JumpHeight = 5;
        Attack = 1;
        Defense = 1;
        Vitality = 1;
        Stamina = 1;
        HungerResistance = 1;
        MaxHealth = 90 + (Vitality * 10);
        MaxEnergy = 100;
        FullHunger = 100;
        FullThirst = 100;

        Health = MaxHealth;
        Energy = MaxEnergy;
        Hunger = FullHunger;
        Thirst = FullThirst;

        YouDiedImage.SetActive(false);
        RestartGameButton.SetActive(false);
        MainMenuButton.SetActive(false);
        Player = GetComponent<PlayerMovement>();
    }
	
	
	void Update ()
    {
        //Timery
        FoodTimer += Time.deltaTime;
        HealthTimer += Time.deltaTime;
        EnergyTimer += Time.deltaTime;
        HungerDamageTimer += Time.deltaTime;

        //Funkcje Regenerujące i Pobierające zasoby Gracza
        HealthRegen();
        FullHealth();
        MinimalStats();
        EnergyRegen();
        FullEnergy();
        HungerDamage();
        if (Sprint == false)
        {
            HungerDown();
        }
        else HungerDownSprint();

        DeathScreen();

        if (Health <= 0) Died = true;
        else Died = false;
    }

    //Funkcja zapobiegająca błędowi z za dużą ilością życia
    void FullHealth()
    {
        if (Health > MaxHealth) 
        {
            Health = MaxHealth;
        } 
    }
    //Funkcja zapobiegająca błędowi z za dużą ilością energi
    void FullEnergy()
    {
        if (Energy > MaxEnergy)
        {
            Energy = MaxEnergy;
        }
    }
    //Regeneracja Energi kiedy głód i napojenie ma wystarczający poziom (mechanika jak z minecrafta)
    void EnergyRegen()
    {
        if (EnergyTimer >= 1 && Hunger >= 30 && Thirst >= 30)
        {
            Energy += Stamina;
            EnergyTimer = 0;
        }
    }
    //Regeneracja Życia
    void HealthRegen()
    {
        if (HealthTimer >= 10 && Hunger >= 20 && Thirst >= 20)
        {
            Health++;
            HealthTimer = 0;
        }
    }
    //Spadanie głodu, przeliczone na około 3 posiłki na 15 minut gry
    void HungerDown()
    {
        if (FoodTimer >= 4 + HungerResistance)
        {
            Hunger--;
            Thirst--;
            FoodTimer = 0;
        }
    }
    //Szybsza strata głodu przy bieganiu
    void HungerDownSprint()
    {
        if (FoodTimer >= 2 + HungerResistance)
        {
            Hunger--;
            Thirst--;
            FoodTimer = 0;
        }
    }
    //Głód lub pragnienie = strata HP
    void HungerDamage()
    {
        if(Hunger <= 1 || Thirst <= 1)
        {
            if(HungerDamageTimer > 1)
            Health -= 1;
        }
    }
    void MinimalStats()
    {
        if (Energy < 0)
        {
            Energy = 0;
        }
        if (Hunger < 0)
        {
            Hunger = 0;
        }
        if (Thirst < 0)
        {
            Thirst = 0;
        }
    }

    //Bartek A.
    void DeathScreen()
    {
        if(Died)
        {
            Player.enabled = false;
            YouDiedImage.SetActive(true);
            RestartGameButton.SetActive(true);
            MainMenuButton.SetActive(true);
        }
        if (!Died)
        {
            Player.enabled = true;
            YouDiedImage.SetActive(false);
            RestartGameButton.SetActive(false);
            MainMenuButton.SetActive(false);
        }

    }

    //Bartek A.
    public void RestartGame() { SceneManager.LoadScene("Game"); }

    //Bartek A.
    public void MainMenu() { SceneManager.LoadScene("Menu"); }
}
//Kondzio

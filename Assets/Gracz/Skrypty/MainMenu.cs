using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    void Start() { }
    
    void Update() { }

    public void StartGame() { SceneManager.LoadScene("Game"); }
    public void ExitGame() { Application.Quit(); }
}

//Bartek A.

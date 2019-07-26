using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public Canvas UI;
    public Canvas PauseMenuUI;

    public PlayerMovement playerMovement;

    //Jest true gdy pause manu jest otwarte
    bool pauseMenuOpened;


    //Ustawienie wartości początkowych
    void Start()
    {
        pauseMenuOpened = false;
        PauseMenuUI.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Otwórz pause menu jeżeli nie jest otwarte
            if (!pauseMenuOpened)
            {
                PauseMenuOpen();
            }
            //Jezeli jest to zamknij
            else
            {
                ClosePauseMenu();
            }
        }
    }

    void PauseMenuOpen()
    {
        //Wyłącz UI, włącz pause menu, wyłącz movement gracza
        UI.enabled = false;
        PauseMenuUI.enabled = true;
        pauseMenuOpened = true;
        playerMovement.enabled = false;
    }

    public void ClosePauseMenu()
    {
        //Włącz Ui, wyłącz pause menu, włącz movement gracza
        UI.enabled = true;
        PauseMenuUI.enabled = false;
        pauseMenuOpened = false;
        playerMovement.enabled = true;
    }
}

//B.Liss

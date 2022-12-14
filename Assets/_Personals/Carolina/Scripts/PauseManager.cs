using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class PauseManager : MonoBehaviour
{
    public bool GamePaused = false;
    public Canvas PauseCanvas;
    public MenuManager MenuManager;
    [SerializeField] public Controls Controls;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Controls.Player.Pause.triggered)
        {
            TogglePause();
        }*/
        
        
        ////Debug.Log(Time.timeScale);
    }

    public void TogglePause()
    {
        if (!GameManager.Instance.GameOver)
        {
            GamePaused = !GamePaused;
            PauseCanvas.enabled = GamePaused;
            if (MenuManager)
            {
                MenuManager.CloseOptions();   
            }

            if (GamePaused)
            {
                Time.timeScale = 0;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Time.timeScale = GameManager.Instance.CurrentTimeScale;
            }   
        }
    }
    
    public void Options()
    {
        GameManager.Instance.MenuManager.Options();
    }

    public void QuitToMenu()
    {
        GameManager.Instance.MenuManager.QuitToMenu();
    }
}

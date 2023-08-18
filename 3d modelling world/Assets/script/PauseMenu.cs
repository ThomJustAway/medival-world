using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public bool IsActivated { get; private set; }
    [SerializeField] private GameObject pauseMenu;


    private void Start()
    {
        pauseMenu.SetActive(false);
        IsActivated = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            ToggledActivated();
        }
    }

    private void ToggledActivated()
    {
        if (IsActivated)
        {
            //close the window
            IsActivated = !IsActivated;
            pauseMenu.SetActive(IsActivated);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            //open the window
            IsActivated = !IsActivated;
            pauseMenu.SetActive(IsActivated);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}

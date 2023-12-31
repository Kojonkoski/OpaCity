using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public bool paused = false;
    public GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (paused == true)
            {
                paused = false;

            }
            else if (paused == false)
            {
                paused = true;

            }

        }

        // This is for actual freezing the game and opens the menu
        if (paused == true)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;

        }

        else if (paused == false)
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }
    }
    public void Continue()
    {
        pauseMenu.SetActive(false);
        paused = false;

    }
}

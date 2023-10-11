using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PauseScript pauseScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");

    }

    public void QuitGame()
    {

        Application.Quit(); 
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("menuScene");

    }

    public void Continue()
    {
        pauseScript.Continue();

    }
}

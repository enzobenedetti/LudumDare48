using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    int level = 0;
    int lastLevel;
    public static bool noMoreLevel = false;
    
    // Start is called before the first frame update
    void Start()
    {
        lastLevel = SceneManager.sceneCountInBuildSettings -1;
        level = SceneManager.GetActiveScene().buildIndex;
    }

    public void StartGame()
    {
        if (level != lastLevel)
            level++;
        if (level == lastLevel)
            noMoreLevel = true;
        GameState.win = false;
        GameState.loose = false;
        GameState.gameDone = false;
        SceneManager.LoadScene(level);
    }

    public void RetartLevel()
    {
        GameState.win = false;
        GameState.loose = false;
        GameState.gameDone = false;
        SceneManager.LoadScene(level);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MenuGame()
    {
        SceneManager.LoadScene(0);
    }
}

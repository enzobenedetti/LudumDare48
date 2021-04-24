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
        lastLevel = SceneManager.sceneCount;
    }

    public void StartGame()
    {
        if (level < lastLevel)
            level++;
        if (level == lastLevel)
            noMoreLevel = true;
        SceneManager.LoadScene(level);
    }

    public void RetartLevel()
    {
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

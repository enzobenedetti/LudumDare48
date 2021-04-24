using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject pause;
    [SerializeField]
    private GameObject win;
    [SerializeField]
    private GameObject lost;
    [SerializeField]
    private GameObject nextButton;

    // Start is called before the first frame update
    void Start()
    {
        pause.SetActive(false);
        win.SetActive(false);
        lost.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        pause.SetActive(GameState.gamePaused);
        win.SetActive(GameState.win);
        lost.SetActive(GameState.loose);
        if (MenuButton.noMoreLevel)
        {
            nextButton.SetActive(false);
        }
    }
}

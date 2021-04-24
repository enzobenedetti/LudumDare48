using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OctoCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GameState.GameLost();
        }
        if (collision.gameObject.tag == "Finish")
        {
            GameState.GameWin();
        }
    }
}

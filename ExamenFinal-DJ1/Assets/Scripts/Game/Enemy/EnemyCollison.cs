using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollison : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameController.instance.vidas -= 1;
            gameObject.SetActive(false);
        }
    }
}

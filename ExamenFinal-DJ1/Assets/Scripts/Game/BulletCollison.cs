using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BulletCollison : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "Player")
        {
            if (other.gameObject.tag != gameObject.tag)
            {
                print("objeto distinto");
                //GameController.instance.score += 10;
                Destroy(gameObject);



            }
            else
            {
                print("objeto igual");
                switch (other.gameObject.tag)
                {
                    case "Brown":
                        GameController.instance.score += 5;break;
                    case "Red":
                        GameController.instance.score += 10; break;
                    case "Yellow":
                        GameController.instance.score += 15; break;
                    case "Cream":
                        GameController.instance.score += 20; break;
                    case "Fly":
                        GameController.instance.score += 50; break;
                }
                //GameController.instance.vidas -= 1;
                Destroy(gameObject);
                other.gameObject.SetActive(false);
            }
        }
    }
}

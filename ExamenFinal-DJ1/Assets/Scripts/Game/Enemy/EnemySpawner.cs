using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> enemies;
    [SerializeField]
    public Vector2 velocity;
    public int tipo=0;

    private List<GameObject> pool = new List<GameObject>();
    private float elapsed;
    private float timeLimit;
    void generatePoolObjects()
    {

        for (int i = 0; i < enemies.Count; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                GameObject ga = Instantiate(enemies[i], new Vector3(transform.position.x, transform.position.y, 1.0f), Quaternion.identity);
                ga.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
                ga.SetActive(false);
                pool.Add(ga);
            }

        }
    }
    void Awake()
    {

        generatePoolObjects();

    }

    void GetFirstDead()
    {
        while (true)
        {

            int index = Random.Range(0, pool.Count);
            if (!pool[index].activeInHierarchy)
            {
                
                pool[index].SetActive(true);
                GameController.instance.cantE += 1;
                if (tipo == 0)
                {
                    pool[index].transform.position = new Vector3(Random.Range(-4.0f, 4.0f), transform.position.y, 0);
                }
                if (tipo == 1)
                {
                    pool[index].transform.position = new Vector3(transform.position.x, transform.position.y, 0);
                }

                pool[index].GetComponent<Rigidbody2D>().velocity = velocity;
                    
                break;
            }
            else
            {
                index = Random.Range(0, pool.Count);
            }
        }
    }
    void FixedUpdate()
    {
        elapsed += Time.deltaTime;
        switch (GameController.instance.ola) 
        {
            case 1: timeLimit = 8f; break;
            case 2: timeLimit = 6f; break;
            case 3: timeLimit = 4f; break;
            case 4: timeLimit = 3f; break;
            case 5: timeLimit = 2f; break;
        }

        if (elapsed >= timeLimit)
        {
            //print("hello");
            elapsed = 0f;
            GetFirstDead();
        }

    }

}

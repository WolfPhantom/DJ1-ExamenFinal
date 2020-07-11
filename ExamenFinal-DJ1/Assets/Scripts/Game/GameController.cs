using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public static GameController instance;
    [Header("HUD")]
    public Text txtScore;
    public Text txtVidas;
    public Text txtOla;
    [SerializeField]
    private List<GameObject> spawners;
    public float score = 0f;
    public float ola = 1;
    public int vidas;
    private int []EW = { 4, 8, 16, 32, 64 };
    public int cantE= 0;

    public string getScore()
    {
        return score.ToString();
    }
    void Start()
    {
        score = 0f;
        if (instance == null)
        {
            instance = this;
        }
        vidas = PlayerPrefs.GetInt("vidas");

    }
    void Update()
    {
        PlayerPrefs.SetFloat("score", score);
        PlayerPrefs.SetFloat("ola", ola);
        txtScore.text = "puntaje: " + score.ToString();
        txtVidas.text = "vidas: " + vidas.ToString();
        txtOla.text = "ola: " + ola.ToString();
        if (vidas == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        ChangeWave();
    }
    void ChangeWave() 
    {
      
        switch (ola) 
        {
            case 1:
                if (spawners[0].gameObject.activeInHierarchy == false && spawners[1].gameObject.activeInHierarchy ==false)
                {
                    spawners[0].gameObject.SetActive(true);
                    spawners[1].gameObject.SetActive(true);
                }
                if (cantE>=4) 
                {
                    ola = 2;
                    cantE = 0;
                }
                break;
            case 2:
                if (spawners[0].gameObject.activeInHierarchy == false && spawners[1].gameObject.activeInHierarchy == false)
                {
                    spawners[0].gameObject.SetActive(true);
                    spawners[1].gameObject.SetActive(true);
                }
                if (cantE >= 8)
                {
                    ola = 3;
                    cantE = 0;
                }
                break;
            case 3:
                if (spawners[2].gameObject.activeInHierarchy == false && spawners[3].gameObject.activeInHierarchy == false)
                {
                    spawners[2].gameObject.SetActive(true);
                    spawners[3].gameObject.SetActive(true);
                }
                if (cantE >= 16)
                {
                    ola = 4;
                    cantE = 0;
                }
                break;
            case 4:
                if (spawners[4].gameObject.activeInHierarchy == false)
                {
                    spawners[4].gameObject.SetActive(true);
                }
                if (cantE >= 32)
                {
                    ola = 5;
                    cantE = 0;
                }
                break;
            case 5:
                if (spawners[5].gameObject.activeInHierarchy == false)
                {
                    spawners[5].gameObject.SetActive(true);
                }
                ola = 5;
                break;
        }
    
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverController : MonoBehaviour
{
    [Header("HUD")]
    public Text txtScore;
    public Text txtOla;


    public float score ;
    public float ola ;
    void Start()
    {
        score = PlayerPrefs.GetFloat("score");
        ola = PlayerPrefs.GetFloat("ola");
        txtScore.text = "puntaje: " + score.ToString();
        txtOla.text = "ola: " + ola.ToString();
        StartCoroutine(GoMenu());
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator GoMenu() 
    {
        
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Menu");
    }
}

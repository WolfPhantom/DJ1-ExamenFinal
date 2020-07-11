using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class SeleccionController : MonoBehaviour
{
    public static SeleccionController instance;
    [SerializeField]
    private Button btnNormal;
    [SerializeField]
    private Button btnDificil;

    public  int  vidas;
    // Start is called before the first frame update
    void Start()
    {
        btnNormal.onClick.AddListener(() => GoGameNormal());
        btnDificil.onClick.AddListener(() => GoGameDificil());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GoGameNormal() 
    {
        PlayerPrefs.SetInt("vidas", 4);
        SceneManager.LoadScene("Game");
    }
    void GoGameDificil()
    {
        PlayerPrefs.SetInt("vidas", 1);
        SceneManager.LoadScene("Game");
    }
}

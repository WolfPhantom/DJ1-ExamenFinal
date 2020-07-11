﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    [SerializeField]
    private Button btnJugar;
    // Start is called before the first frame update
    void Start()
    {
        btnJugar.onClick.AddListener(() => GoSeleccion());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GoSeleccion() 
    {
        SceneManager.LoadScene("Seleccion");
    }
}

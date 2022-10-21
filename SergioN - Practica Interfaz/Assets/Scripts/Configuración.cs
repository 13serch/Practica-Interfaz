using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Configuración : MonoBehaviour
{


    [SerializeField]
    GameObject boton3;


    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveLocal(boton3, new Vector3(-340f, -80f, 0f), 6f).setEaseInCirc();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

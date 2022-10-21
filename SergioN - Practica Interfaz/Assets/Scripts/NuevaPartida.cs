using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuevaPartida : MonoBehaviour
{


    [SerializeField]
    GameObject boton2;

    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveLocal(boton2, new Vector3(-340f, -50f, 0f), 6f).setEaseInCirc();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

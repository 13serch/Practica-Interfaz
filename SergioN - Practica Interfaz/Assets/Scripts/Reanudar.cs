using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reanudar : MonoBehaviour
{


    [SerializeField]
    GameObject boton1;

    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveLocal(boton1, new Vector3(-340f, -20f, 0f), 6f).setEaseInCirc();
    }

    
    public void ScaleUp()
    {

        LeanTween.scale(gameObject, Vector3.one * 1.2f, 0.5f).setEaseInBounce();

    }

    public void ScaleDown()
    {

        LeanTween.scale(gameObject, Vector3.one, 0.5f);

    }
}

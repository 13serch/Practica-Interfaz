using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPrincipal : MonoBehaviour
{

    [SerializeField]
    GameObject foto;


    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveLocal(foto, new Vector3(-340f, 95f, 0f), 6f).setEaseInCirc();
    }

    // Update is called once per frame
    void Update()
    {
        
    } 
}

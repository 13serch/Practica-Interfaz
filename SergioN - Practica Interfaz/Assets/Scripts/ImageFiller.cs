using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ImageFiller : MonoBehaviour
{

    Image image;


    void Start()
    {
        image = GetComponent<Image>();
        image.fillAmount = 1f;
    }


    //nueva funcion que rellena +0.1 el icono
    //nueva funcion que disminuye en -0.1 el fill del icono




        //public void Fil(float valor)
            // image.fillAmount += valor;      con esta lo haces solo con 1 funcion

    

    public void AddVida()
    {
        image.fillAmount += 0.1f;
    }
                                             // con estas necesitas una funcion para cada uno
    public void RestarVida()
    {
        image.fillAmount -= 0.1f;
    }



}  
    
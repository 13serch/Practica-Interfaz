using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField]
    GameObject logo;
   



    void Start()
    {
        //LeanTween.moveLocal(logo, new Vector3(360f, 70f,0f),)
        LeanTween.moveLocalY(logo, 0f, 0.7f).setEaseInOutBounce().setOnComplete(Latido);
        LeanTween.moveLocalX(logo, 0f, 0.7f);
       
    }

    // Update is called once per frame
    void Latido()
    {
        LeanTween.scale(logo, Vector4.one, 0.75f).setEaseOutBack().setOnComplete(() => {
            LeanTween.alphaCanvas(gameObject.GetComponent<CanvasGroup>(), 0.0f, 2f).setOnComplete(Desactivar);
            
        });
    }


    void Desactivar()
    {
        gameObject.SetActive(false);
        //Activar el menu principal...


    }

   
}




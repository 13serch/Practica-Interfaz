using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{

    [SerializeField]
    Vector3 fuerza;

    Rigidbody body;   //Rigidbody para añadir fuerza a un objeto



    void Start()
    {
        body = GetComponent<Rigidbody>();   //para que desde el Unity podamos usarlo
    }


    public void AddForces()
    {
        body.AddForce(fuerza, ForceMode.Impulse);  //AddForce permite darle el empujón

        // modo de impulso (ForceMode.Impulse) con la fuerza ''fuerza'' en este caso en Vector3 como pusimos arriba
    }


    public void AddForces(Vector3 parametro)
    {
        body.AddForce(fuerza, ForceMode.Impulse);
    }


}

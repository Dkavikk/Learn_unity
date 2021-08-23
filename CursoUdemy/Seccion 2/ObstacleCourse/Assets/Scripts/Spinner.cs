using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotateSpeed;

    void Update()
    {
        /*
        *"transform" es para especificar que lo que vamos a hacer es una tranformacion (o)
        *"Ratate" es para especificar que es de Rotacion
        transform.Rotate(x,y,z);         //*(Por defecto es int)
        transform.Rotate(xf,yf,zf);      //*(la "f" especifica que es una variable float)
        */
        float yVal = Time.deltaTime * rotateSpeed;

        transform.Rotate(0, yVal, 0);
    }
}

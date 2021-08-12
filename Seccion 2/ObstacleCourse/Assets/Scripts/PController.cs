using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PController : MonoBehaviour
{
    public int ScorePerHit;


    [SerializeField] float moveSpeed = 5.5f;
   
  //[SerializeField] Se utiliza para hacer una variable privada en publica.
  //                 esto solo hace que para algunas objetos sea publica
   
 // void Start() se ejecuta una sola ves y es el frame 1
    void Start()
    {
        PrintInstruction();
    }

    // void Update() Se actualiza una vez por frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Bienvenido al juego de la papas ");
        Debug.Log("Papas");
        Debug.Log("Mayos");
    }

    void MovePlayer()
    {
        /*
       *"transform" es para especificar que lo que vamos a hacer es una tranformacion (o)
       *"Translete" es para especificar que es de translado
        transform.Translate(x,y,z);         //*(Por defecto es int)
        transform.Translate(xf,yf,zf);      //*(la "f" especifica que es una variable float)
        */

        float xVal = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zVal = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xVal, 0, zVal);
    }
}

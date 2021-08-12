using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer mRenderer;
    Rigidbody rBody;
    [SerializeField] float timeWait = 0f;
    void Start()
    {
        // guardo los GetComponent<>(); en variables
        mRenderer = GetComponent<MeshRenderer>();
        rBody = GetComponent<Rigidbody>();
        
        //        enabled = false //* es para que este desabilitada la malla
        mRenderer.enabled = false;
        //    useGravity = false //* es para que este desabilitada la Gravedad
        rBody.useGravity = false;
    }

    void Update()
    {
        if (timeWait > 0f)
        {
            mRenderer.enabled = true;
            //  pregunta si el tiempo de inicio de la aplicacion "Time.time" es mayor que el tiempo de espera "timeWait"
            if (Time.time > timeWait)
            {
                rBody.useGravity = true;
            }
        } 
    }

    private void OnTriggerEnter(Collider other)
     {
        if (other.tag == "Player")
        {
            if (timeWait == 0f)
            {
                /*
                Guarda un numero random en "timeWait"
                                  Range(float min, float max); de termina cual es el valor minimo que puede salir y el maximo*/
                timeWait = Random.Range(Time.time, Time.time + 2f);
            }
        } 
    }
}

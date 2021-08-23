using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    PController PScore;
    bool hitObtacle = false;

    // OnCollisionEnter Cuando comiensa la colision
    private void OnCollisionEnter(Collision other)
    {
        PScore = other.gameObject.GetComponent<PController>();
        //other.gameObject.tag
        if (other.gameObject.CompareTag("Player"))
        {
          //esto es un method 
            CollisionHit();
        }
    }

    void CollisionHit()
    {
        // Debug.Log(hitObtacle + " Antes");
        if (hitObtacle == false)
        {
            //Canbia el color del objeto colicionado 
            GetComponent<MeshRenderer>().material.color = Color.red;

            //         ++ le dice que incremente el valor 1 a 1
            PScore.ScorePerHit++;

            //imprime el valor de la variable
            Debug.Log("Aweonao pa grande ya chocaste " + PScore.ScorePerHit + " :c");
            Debug.Log("¡HuY! Me golpeaste ;c *SE MUERE*");

            //agrega un tag al objeto colicionado
            hitObtacle = true;
        }
    }
}

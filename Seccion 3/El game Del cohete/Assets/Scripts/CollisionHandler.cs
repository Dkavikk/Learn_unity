using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "ThingThatKill":
                ReloadLvl();
                Debug.Log("chocaste");
                break;
            case "Friendly":
                Debug.Log("esta es una superficie segura");
                break;
            case "Fuel":
                Debug.Log("Tomaste combustible");
                break;
            case "Finish":
                Debug.Log("¡OH!, a llegado a la meta :D");
                break;
            case "Start":
                Debug.Log("Esta es la base de lanzamiento");
                break;
                  
            default:
                Debug.Log("Esto no deberia salir nunca");
                break;
        }
    }


    void ReloadLvl()
    {
        int currenSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currenSceneIndex);
    }
}

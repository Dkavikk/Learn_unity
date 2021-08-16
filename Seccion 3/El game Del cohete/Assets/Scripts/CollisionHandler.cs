using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    Movement movementController;
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "ThingThatKill":
                Invoke("ReloadLvl", 3f);
                break;
            case "Friendly":
                Debug.Log("esta es una superficie segura");
                break;
            case "Fuel":
                Debug.Log("Tomaste combustible");
                break;
            case "Finish":
                LoadNextLvl();
                break;
            case "Start":
                Debug.Log("Esta es la base de lanzamiento");
                break;
          //default: este se ejecuta cuando ninguno de loas caso anteriores corresponde al valor de la variable
            default:
                Debug.Log("Esto no deberia salir nunca");
                break;
        }
    }

    // para recargar en nivel en el que esta
    void ReloadLvl()
    {
        //                                                   buildIndex;    Devuelve el índice de la escena en la Build Settings
        //                                  GetActiveScene().               Obtiene la escena en la que estamos
        //                     SceneManager.                                es el que gestiona las ecena mientra se ejecuta el juego
        int currenSceneIndex = SceneManager.GetActiveScene().buildIndex;
        //           LoadScene  Cargala escena por su nombre (es en string) o index (es en int) en Build Settings.
        SceneManager.LoadScene(currenSceneIndex);
        movementController.RBody.freezeRotation = false;
    }


    // para avanzar a l siguiente nivel, encaso de que no halla mas niveles vuelve al primero (0)
    void LoadNextLvl()
    {
        int currenSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextLevel = currenSceneIndex + 1;

        //0, 1, 2, 3, 4
        //1, 2, 3, 4, 5
        //                            sceneCountInBuildSettings Numero de escenas en Build Settings
        if (nextLevel == SceneManager.sceneCountInBuildSettings)
        {
            nextLevel = 0;
        }
        SceneManager.LoadScene(nextLevel);
    }
}

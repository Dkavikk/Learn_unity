using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 2f;
    [SerializeField] AudioClip SFXFinish;
    [SerializeField] AudioClip SFXDeath;

    AudioSource audioSource;

    bool isTransitioning = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (isTransitioning != true)
        {
            switch (other.gameObject.tag)
            {
                case "ThingThatKill":
                    StartCrashSequence();
                    break;
                case "Friendly":
                    Debug.Log("esta es una superficie segura");
                    break;
                case "Fuel":
                    Debug.Log("Tomaste combustible");
                    break;
                case "Finish":
                    StartNextLevelSequence();
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
    }

    // le pone un delay al method LoadNextLevelSequence, y inmoviliza al jugador
    void StartNextLevelSequence()
    {
        isTransitioning = true;
        audioSource.Stop();
        audioSource.PlayOneShot(SFXFinish);
        GetComponent<Movement>().enabled = false;
        Invoke("LoadNextLevel", levelLoadDelay);
    }

    // le pone un delay al method ReloadLevel, y inmoviliza al jugador
    void StartCrashSequence()
    {
        isTransitioning = true;
        audioSource.Stop();
        audioSource.PlayOneShot(SFXDeath);
        GetComponent<Movement>().enabled = false;
        Invoke("ReloadLevel", levelLoadDelay);
    }

    // para recargar en nivel en el que esta
    void ReloadLevel()
    {
        //                                                   buildIndex;    Devuelve el índice de la escena en la Build Settings.
        //                                  GetActiveScene().               Obtiene la escena en la que estamos.
        //                     SceneManager.                                es el que gestiona las ecena mientra se ejecuta el juego.
        int currenSceneIndex = SceneManager.GetActiveScene().buildIndex;
        //           LoadScene  Cargala escena por su nombre (es en string) o index (es en int) en Build Settings.
        SceneManager.LoadScene(currenSceneIndex);
    }

    // para avanzar a l siguiente nivel, encaso de que no halla mas niveles vuelve al primero (0).
    void LoadNextLevel()
    {
        int currenSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextLevel = currenSceneIndex + 1;

        //para acordarme como cuenta las escenas y como cuenta las cantidad de escenas.
        //0, 1, 2, 3, 4
        //1, 2, 3, 4, 5
        //                            sceneCountInBuildSettings Numero de escenas en Build Settings.
        if (nextLevel == SceneManager.sceneCountInBuildSettings)
        {
            nextLevel = 0;
        }
        SceneManager.LoadScene(nextLevel);
    }
}

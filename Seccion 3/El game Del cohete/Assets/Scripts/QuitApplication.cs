using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Application.Quit();
            Debug.Log("Cerrandote :)");
        }
    }
}

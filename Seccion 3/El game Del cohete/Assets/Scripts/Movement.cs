using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float mainThrust;
    [SerializeField] float rotationThrust;
    [SerializeField] AudioClip SFXmainEngine;

    Rigidbody rb;
    AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }


    void ProcessThrust()
    {
        //  Input.GetKey(KeyCode.<Codigo de la tecla>), se utiliza para saber cuando una tecla es presionada 
        if (Input.GetKey(KeyCode.Space))
        {
            //                             up   = Vector3(0, 1, 0)
            //                     Vector3.     Abreviacion para escribir vectores
            //    AddRelativeForce(             Agrega una fuerza al rigiBody en relación con su sistema de coordenadas
            rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(SFXmainEngine);
            }
        }
        else
        {
            audioSource.Stop();
        }
    }
    void ProcessRotation()
    {
        //  Input.GetKey devuelve verdadero mientras el usuario mantiene presionada la tecla
        if (Input.GetKey(KeyCode.D))
        {
            ApplyRotation(-rotationThrust);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            ApplyRotation(rotationThrust);
        }
    }

    void ApplyRotation(float rotationThisFrame)
    {
        GetComponent<Rigidbody>().freezeRotation = true;
        //                      .forward    = Vector3(0, 0, 1)
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false;
    }
}

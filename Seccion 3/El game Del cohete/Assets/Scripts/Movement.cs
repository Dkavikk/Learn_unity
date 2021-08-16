using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody RBody;
    public AudioSource ASource;

    [SerializeField] float mainThruast;
    [SerializeField] float rotationThrust;

    void Start()
    {
        RBody = GetComponent<Rigidbody>();
        ASource = GetComponent<AudioSource>();

        ASource.Stop();
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
            RBody.AddRelativeForce(Vector3.up * mainThruast * Time.deltaTime);
            if (!ASource.isPlaying){
                ASource.Play();
            }
        }
        else
        {
                ASource.Pause();
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
        RBody.freezeRotation = true;
        //                      .forward    = Vector3(0, 0, 1)
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        RBody.freezeRotation = false;
    }
}

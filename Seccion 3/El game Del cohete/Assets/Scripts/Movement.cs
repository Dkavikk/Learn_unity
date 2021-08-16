using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float mainThrust;
    [SerializeField] float rotationThrust;

    [SerializeField] AudioClip SFXMainEngine;
    [SerializeField] ParticleSystem PFXMainEngine;
    [SerializeField] ParticleSystem rPFXMainEngine;
    [SerializeField] ParticleSystem lPFXMainEngine;

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
            StartThrusting();
        }
        else
        {
            StopMainAudioAndParticle();
        }
    }
    void ProcessRotation()
    {
        //  Input.GetKey devuelve verdadero mientras el usuario mantiene presionada la tecla
        if (Input.GetKey(KeyCode.D))
        {
            StartRotatingL();
        }
        else if (Input.GetKey(KeyCode.A))
        {
            StartRotatingR();
        }
        else
        {
            StopParticlesLAndR();
        }
    }
    private void StopMainAudioAndParticle()
    {
        PFXMainEngine.Stop();
        audioSource.Stop();
    }
    void StartThrusting()
    {
        //                             up   = Vector3(0, 1, 0)
        //                     Vector3.     Abreviacion para escribir vectores
        //    AddRelativeForce(             Agrega una fuerza al rigiBody en relación con su sistema de coordenadas
        rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        if (!PFXMainEngine.isPlaying)
        {
            PFXMainEngine.Play();
        }
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(SFXMainEngine);
        }
    }
    void StartRotatingR()
    {
        if (!rPFXMainEngine.isPlaying)
        {
            rPFXMainEngine.Play();
        }
        ApplyRotation(rotationThrust);
    }

    void StartRotatingL()
    {
        if (!lPFXMainEngine.isPlaying)
        {
            lPFXMainEngine.Play();
        }
        ApplyRotation(-rotationThrust);
    }
    void StopParticlesLAndR()
    {
        lPFXMainEngine.Stop();
        rPFXMainEngine.Stop();
    }
    void ApplyRotation(float rotationThisFrame)
    {
        GetComponent<Rigidbody>().freezeRotation = true;
        //                      .forward    = Vector3(0, 0, 1)
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false;
    }
}

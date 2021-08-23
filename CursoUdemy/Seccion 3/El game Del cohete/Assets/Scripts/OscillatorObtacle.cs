using UnityEngine;

public class OscillatorObtacle : MonoBehaviour
{
    Vector3 startingPosition;
    [SerializeField] Vector3 movementVector;
    [SerializeField] [Range(0,1)] float movementFactor;
    [SerializeField] float period = 2f;
    [SerializeField] bool senoidal = false;
    void Start()
    {
        startingPosition = transform.position;
        Debug.Log(startingPosition);
    }

    void Update()
    {
        if (period <= Mathf.Epsilon) { return; }
        float cycles = Time.time / period;

        const float tau = Mathf.PI * 2f;
        float rawSinWave = Mathf.Sin(cycles * tau);

        if (senoidal == false)
        {
            movementFactor = (rawSinWave + 1f) / 2f;
        }
        else
        {
            movementFactor = rawSinWave;
        }

        Vector3 offSet = movementVector * movementFactor;
        transform.position = startingPosition + offSet;
    }
}
 
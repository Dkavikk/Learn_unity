using UnityEngine;

public class OscillatorObtacle : MonoBehaviour
{
    Vector3 startingPosition;
    [SerializeField] Vector3 movementVector;
    [SerializeField] [Range(0,1)] float movementFactor;
    void Start()
    {
        startingPosition = transform.position;
        Debug.Log(startingPosition);
    }

    void Update()
    {
        Vector3 offSet = movementVector * movementFactor;
        transform.position = startingPosition + offSet;
    }
}
 
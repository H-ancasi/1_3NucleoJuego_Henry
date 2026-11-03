using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 90f;
    [SerializeField] private float floatSpeed = 0.1f;   
    [SerializeField] private float floatHeight = 0.2f;  

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);

        float newY = startPosition.y + Mathf.PingPong(Time.time * floatSpeed, floatHeight);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
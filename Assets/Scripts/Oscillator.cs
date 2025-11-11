using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField] private Vector3 direction = Vector3.right; //Direction of the movement
    [SerializeField] private float amplitude = 2f; // How far does it swing
    [SerializeField] private float frequency = 1f; // How fast does it move.

    private Vector3 startPosition; //Starting point

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        //Calculating the movement with sin.
        float offset = Mathf.Sin(Time.time * frequency) * amplitude;

        //moving the object.
        transform.position = startPosition + direction.normalized * offset;
    }
}
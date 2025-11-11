using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 rotationAxis = Vector3.up; // Rotation axis (Y = around itself)
    [SerializeField] private float rotationSpeed = 50f; // Speed in degrees per second

    void Update()
    {
        // Rotate the object
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }
}
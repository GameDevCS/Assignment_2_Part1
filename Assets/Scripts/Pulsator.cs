using UnityEngine;

public class Pulsator : MonoBehaviour
{
    [SerializeField] private float minScale = 0.5f; // Minimal size .
    [SerializeField] private float maxScale = 1.5f; // Maxinal size.    
    [SerializeField] private float pulseSpeed = 2f; // Pulse speed.

    private Vector3 originalScale;

    void Start()
    {

        originalScale = transform.localScale;
    }

    void Update()
    {
        //Calculating the size.
        float scale = Mathf.Lerp(minScale, maxScale,
                                 (Mathf.Sin(Time.time * pulseSpeed) + 1f) / 2f);

        // Apply size.
        transform.localScale = originalScale * scale;
    }
}
using UnityEngine;
using UnityEngine.InputSystem;

public class HideShowToggle : MonoBehaviour
{
    [SerializeField] private Key toggleKey = Key.Space; // Key to press
    [SerializeField] private Renderer objectRenderer; // Renderer to toggle

    private bool isVisible = true;

    void Start()
    {
        // Validate that renderer is assigned
        if (objectRenderer == null)
        {
            objectRenderer = GetComponent<Renderer>();
        }
    }

    void Update()
    {
        // Check if the "space" key was pressed 
        if (Keyboard.current != null && Keyboard.current[toggleKey].wasPressedThisFrame)
        {
            // Show or hide the character
            isVisible = !isVisible;
            objectRenderer.enabled = isVisible;
        }
    }
}
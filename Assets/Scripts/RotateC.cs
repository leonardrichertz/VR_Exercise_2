using UnityEngine;

public class RotateC : MonoBehaviour
{
    [Range(-180f, 180f)]
    public float rotationSpeed = 90f; // Grad pro Sekunde

    void Update()
    {
        // Rotiert das Objekt um die y-Achse
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}

using UnityEngine;

public class SwimAnimation : MonoBehaviour
{
    public float swimAmplitude = 0.5f;
    public float swimFrequency = 1f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        Vector3 swimPosition = startPosition;
        swimPosition.y += Mathf.Sin(Time.time * swimFrequency) * swimAmplitude;

        transform.position = swimPosition;
    }
}

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float swimSpeed = 5f;
    public Vector3 bottomPosition;
    public Vector3 topPosition;
    public Vector3 leftPosition;
    public Vector3 rightPosition;

    private Vector3 targetPosition;

    void Start()
    {
        // Initialize the target position to the current position
        targetPosition = transform.position;
    }

    void Update()
    {
        // Move forward continuously
        transform.Translate(Vector3.forward * swimSpeed * Time.deltaTime);

        // Placeholder for swipe controls - using keyboard inputs
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            targetPosition = bottomPosition;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            targetPosition = topPosition;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            targetPosition = leftPosition;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            targetPosition = rightPosition;
        }

        // Move towards the target position
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * swimSpeed);
    }
}

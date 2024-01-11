using UnityEngine;

public class InfiniteEnvironment : MonoBehaviour
{
    public GameObject environmentPrefab;
    public float speed = 5f;
    public float threshold = -10f;
    public float spawnDistance = 20f;

    void Update()
    {
        // Move the environment backward
        transform.Translate(Vector3.back * speed * Time.deltaTime);

        // Check if the environment has moved past the threshold
        if (transform.position.z < threshold)
        {
            // Reposition the environment
            transform.position = new Vector3(transform.position.x, transform.position.y, spawnDistance);
        }
    }
}

using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private static int playerLives = 3;

    void Start()
    {
        Debug.Log($"Player Lives: {playerLives}");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            if (playerLives > 0)
            {
                playerLives--;
                Debug.Log($"Player Lives: {playerLives}");
            }
            else
            {
                Debug.Log("Game over");
            }
            Destroy(gameObject);
        }
    }
}

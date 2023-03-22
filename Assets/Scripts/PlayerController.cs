using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public float zRangeFwd = 5.0f;
    public float zRangeBkw = 8.0f;
    public GameObject projectilePrefab;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -zRangeBkw)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRangeBkw);
        }
        if (transform.position.z > zRangeFwd)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeFwd);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
    }
}

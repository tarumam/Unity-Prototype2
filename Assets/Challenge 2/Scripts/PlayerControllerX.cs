using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float secondsBetweenShots = 1.0f;
    private float nextShotTime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        var canShot = nextShotTime <= 0;
        nextShotTime -= Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canShot)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            nextShotTime = secondsBetweenShots;
        }
    }
}

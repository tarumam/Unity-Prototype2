using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject[] carnivoreAnimalPrefabs;
    private float spawnRangeX = 10;
    private int spawnRangeZ = 9;
    private float spawnPosZ = 30;
    private float spawnPosX = 30;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnCarnivoreAnimal", startDelay, spawnInterval * 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnCarnivoreAnimal()
    {

        float spawnPosition = Random.Range(0, 10) % 2 == 0 ? spawnPosX * -1 : spawnPosX;
        int animalIndex = Random.Range(0, carnivoreAnimalPrefabs.Length);

        Quaternion rotation;

        rotation = spawnPosition > 0 ? Quaternion.Euler(0, 270, 0) : Quaternion.Euler(0, 90, 0);

        Vector3 spawnPos = new Vector3(spawnPosition, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(carnivoreAnimalPrefabs[animalIndex], spawnPos, rotation);
    }
}

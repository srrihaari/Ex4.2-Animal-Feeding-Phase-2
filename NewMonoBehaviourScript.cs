using UnityEngine.UIElements;

private float spawnRange = 10;
private float spawnPosZ = 10;
private float startDelay = 2;
private float spawnInterval = 1.5f;

void Start()
{
    InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
}

void Update()
{ }

void SpawnRandomAnimal()
{
    int animalIndex = Random.Range(0, animalPrefabs, Length);
    Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
    Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
}
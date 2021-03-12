using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    [SerializeField] private int NumberOfZombieToSpawn;
    [SerializeField] private GameObject[] ZombiePrefabs;
    [SerializeField] private SpawnerVolumes[] SpawnVolumes;

    private GameObject FollowGameObject;

    // Start is called before the first frame update
    void Start()
    {
        FollowGameObject = GameObject.FindGameObjectWithTag("Player");

        for (int zombieCount = 0; zombieCount < NumberOfZombieToSpawn; zombieCount++)
        {
            SpawnZombie();
        }
    }

    private void SpawnZombie()
    {
        GameObject zombieToSpawn = ZombiePrefabs[Random.Range(0, ZombiePrefabs.Length)];
        SpawnerVolumes spawnVolume = SpawnVolumes[Random.Range(0, SpawnVolumes.Length)];

        GameObject zombie = Instantiate(zombieToSpawn, spawnVolume.GetPositionInBounds(), spawnVolume.transform.rotation);

        zombie.GetComponent<ZombieComponent>().Initialize(FollowGameObject);
    }
}

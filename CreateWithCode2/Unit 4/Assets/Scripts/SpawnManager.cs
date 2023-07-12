//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    public float spawnRange = 9;
    public int InitialSpawnNumber = 3;
    public int MaxSpawnNumber = 32;

    private int waves = 1;
    // Start is called before the first frame update
    void Start()
    {

   //     SpawnEnemyWave(SpawnNumber);
    }

    private void SpawnEnemyWave(int SpawnNumber) 
    {
        for (int i = 0; i < SpawnNumber; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition() , enemyPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPosition() 
    {
        return new Vector3(getRandomRange(), 0, getRandomRange());
    }

    private float getRandomRange()
    {
        return Random.Range(-spawnRange, spawnRange);
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectsOfType<Enemy>().Length == 0)
        {
            SpawnEnemyWave(Random.Range(InitialSpawnNumber,Mathf.Clamp(InitialSpawnNumber * waves, InitialSpawnNumber, MaxSpawnNumber)));
            Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
            waves++;
        }
        
    }
}

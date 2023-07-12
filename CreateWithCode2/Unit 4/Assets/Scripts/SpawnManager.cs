//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    public GameObject spawn;
    public float spawnRange = 9;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(spawn, GenerateSpawnPosition() , spawn.transform.rotation);
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

    }
}

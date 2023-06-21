using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject PrefabToSpawn;

    public float startDelay = 2, repeatRate = 2;

    private Vector3 spawnLocation = new Vector3(25,0,0);

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacule", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacule()
    {
        Instantiate(PrefabToSpawn, spawnLocation, PrefabToSpawn.transform.rotation);
    }
}

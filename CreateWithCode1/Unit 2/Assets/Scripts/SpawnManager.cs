using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] listofProyectile;
    System.Random rand = new System.Random();
    public Vector2 spawnRange = new Vector2(20,20);
    int animalIndex;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomAnimal()
    {

        animalIndex = rand.Next(0,listofProyectile.Length);
        // Instantiate
        Instantiate(
            listofProyectile[animalIndex],
                new Vector3(Random.Range(-spawnRange.x,spawnRange.x),0,spawnRange.y),
                listofProyectile[animalIndex].transform.rotation);

    }
}

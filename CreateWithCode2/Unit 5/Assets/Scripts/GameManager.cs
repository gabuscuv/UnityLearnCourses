using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour, IGameManager
{
    public List<GameObject> targets;

    public TextMeshProUGUI scoreText;

    public float spawnRate = 1.0f;

    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());
        scoreText.text = "Score: " + score;
    }

    IEnumerator SpawnTarget()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            Instantiate(targets[Random.Range(0, targets.Count)]);
        }
    }

    public void UpdateScore(int _score) 
    {
        this.score += _score;
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour, IGameManager
{
    public List<GameObject> targets;

    public TextMeshProUGUI scoreText;

    public float spawnRate = 1.0f;

    public GameObject gameOverMenu;
    private int score = 0;
    private bool isGameActive = true;

    void Start()
    {
        //gameOverMenu = GameObject.Find("GameOverMenu");
    }
    // Start is called before the first frame update
    public void StartGame(int Difficulty)
    {
        score = 0;
        spawnRate /= Difficulty;
        isGameActive = true;
        scoreText.text = "Score: " + score;
        StartCoroutine(SpawnTarget());
    }

    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            Instantiate(targets[Random.Range(0, targets.Count)]);
        }
    }

    public void UpdateScore(int _score)
    {
        if (!isGameActive) { return; }
        this.score += _score;
        scoreText.text = "Score: " + score;
    }

    public void RestartGame() 
    {
        if (! isGameActive)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //isGameActive = true;
    }

    public void GameOver()
    {
        isGameActive = false;
        gameOverMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

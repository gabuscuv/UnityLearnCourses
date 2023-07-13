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
    public TextMeshProUGUI gameOverText;

    public float spawnRate = 1.0f;

    public Button restartButton;

    private int score = 0;
    private bool isGameActive = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());
        scoreText.text = "Score: " + score;
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
        //Debug.Log("Hi!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //isGameActive = true;
    }

    public void GameOver()
    {
        isGameActive = false;
        gameOverText.gameObject.SetActive(true);
        
        restartButton.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

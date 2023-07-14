using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button button;
    private IGameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<IGameManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }

    void SetDifficulty()
    {
        var dif = 0;
        switch (gameObject.name) 
        { 
            case "EasyButton" : dif = 1; break;
            case "NormalButton" : dif = 2; break;
            case "HardButton" : dif = 3; break;
        }
        gameManager.StartGame(dif);
        GameObject.Find("TitleMenu").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

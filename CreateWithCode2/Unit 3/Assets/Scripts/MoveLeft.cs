using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private float leftBound = -15;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (! playerController.isGameOver)
        {
            this.transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        // 
        // This is the method used for the tutorial, BUT
        // I think is better make a GameObject with Collision where is wanted to destroy.
        // because allows a more range of destroy objects without change code.
        if( transform.position.x < leftBound && gameObject.CompareTag("Obstacule"))
        {
            Destroy(gameObject);
        }
    }
}

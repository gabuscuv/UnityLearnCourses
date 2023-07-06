using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    public Vector3 offsetResetPosition;

    private Vector3 initialPosition;
    private float repeatWidth;

    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        repeatWidth= this.GetComponent<BoxCollider>().size.x / 2;
        initialPosition = transform.position;
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( ! playerController.isGameOver && transform.position.x < initialPosition.x - repeatWidth)
        //if ( (initialPosition.x + repeatWidth + offsetResetPosition.x) > transform.position.x)
        {
            transform.position = initialPosition;
        }
        
    }
}

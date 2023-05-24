using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z > topBound ||
            this.transform.position.z < -topBound
            )
        {
            Debug.Log("Game over");
            Destroy(gameObject);
        }
    }
}

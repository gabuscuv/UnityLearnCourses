using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardd : MonoBehaviour
{
    public float speed = 40.0f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.forward * Time.deltaTime * speed);

    //   if (this.transform.position.z > 50) { Destroy(gameObject); }
    }
}

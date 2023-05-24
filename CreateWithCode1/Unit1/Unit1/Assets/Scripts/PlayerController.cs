using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public float turnSpeed = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the car forward
        this.transform.Translate(Vector3.forward * Time.deltaTime * speed * Input.GetAxis("Vertical"));
        this.transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * Input.GetAxis("Horizontal"));
    }
}

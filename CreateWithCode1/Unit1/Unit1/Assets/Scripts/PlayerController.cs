using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 20;
    [SerializeField] private float turnSpeed = 20;

      // Update is called once per frame
    void FixedUpdate()
    {
        // Move the car forward
        this.transform.Translate(Vector3.forward * Time.deltaTime * speed * Input.GetAxis("Vertical"));
        this.transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * Input.GetAxis("Horizontal"));
    }
}

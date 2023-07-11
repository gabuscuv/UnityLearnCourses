using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 5.0f;
    private Rigidbody rigidBody;
    private GameObject focalPointObject;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        focalPointObject = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.AddForce( focalPointObject.transform.forward * Input.GetAxis("Vertical") * playerSpeed);
    }
}

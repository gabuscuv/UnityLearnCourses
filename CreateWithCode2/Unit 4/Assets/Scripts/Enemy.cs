using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;

    Rigidbody rigidBody;
    GameObject playerObject;
    

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        playerObject = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < 0) 
        {
            Destroy(this);
        }
        rigidBody.AddForce(GetDistanceFromPlayer() * speed );
    }

    Vector3 GetDistanceFromPlayer() 
    {
        return (playerObject.transform.position - transform.position).normalized;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody rigidBody;

    private float
                minSpeed = 12,
                maxSpeed = 16,
                maxTorque = 10,
                xRange = 4, 
                ySpawnPosition = -6;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.AddForce(GetARandomForce(), ForceMode.Impulse);
        rigidBody.AddTorque(
                GetARandomTorque(),
                GetARandomTorque(),
                GetARandomTorque(),
                ForceMode.Impulse
            );
        this.transform.position = GetARandomPosition();
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider collider)
    {
        Destroy(gameObject);
    }

    Vector3 GetARandomPosition()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPosition);
    }

    float GetARandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    Vector3 GetARandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }
    // Update is called once per frame
    void Update()
    {

    }
}

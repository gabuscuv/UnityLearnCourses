using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 5.0f;
    public float powerupStrength = 15.0f;

    public GameObject powerupIndicator;

    private Rigidbody rigidBody;
    private GameObject focalPointObject;
    private bool hasPowerUp;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        focalPointObject = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.AddForce(focalPointObject.transform.forward * Input.GetAxis("Vertical") * playerSpeed);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            powerupIndicator.SetActive(true);
            Destroy(collider.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerUp)
        {
            
            Debug.Log("Colliding with a Enemy called: " + collision.gameObject.name);

            collision
                    .gameObject
                    .GetComponent<Rigidbody>()
                    .AddForce( 
                        (collision.gameObject.transform.position - this.transform.position) 
                            * powerupStrength, 
                        ForceMode.Impulse);
            //Destroy(collision.gameObject);
        }
    }

    IEnumerator PowerupCountdownRoutine() 
    {
        yield return new WaitForSeconds(7);
        powerupIndicator.SetActive(false);
        hasPowerUp = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float limit = 10.0f;
    public GameObject projectilePrefab;

    // public GameObject bound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a Projecitle
            Instantiate(projectilePrefab, this.transform.position, projectilePrefab.transform.rotation);
        }

        this.horizontalInput = Input.GetAxis("Horizontal");
        if( (horizontalInput < 0 && this.transform.position.x > -limit) ||
         ( horizontalInput > 0 && this.transform.position.x < limit )
        ) 
        {
        this.transform.Translate(Vector3.right 
        * Input.GetAxis("Horizontal") * Time.deltaTime * speed);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProppellerSpinner : MonoBehaviour
{
    public float rotationspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate( Vector3.back * rotationspeed * Time.deltaTime );
    }
}

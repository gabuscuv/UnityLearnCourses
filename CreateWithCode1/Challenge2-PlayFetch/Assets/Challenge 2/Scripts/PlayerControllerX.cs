using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool block;
    private float cooldownDuration = 1.0f;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if ( !block && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            Invoke("FreeBlock",cooldownDuration);
            block = true;
        }
    }

    void FreeBlock()
    {
        block = false;
    }
}

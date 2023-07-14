using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private Vector3 cameraoffset = new Vector3(0, 5, -7);

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + cameraoffset;
    }
}

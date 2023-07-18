using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
  //[SerializeField] private float speed = 20;
  [SerializeField] private float turnSpeed = 20;
  [SerializeField] private float horsePower = 20;

  private Rigidbody rigidBody;
  private float speed;

  [SerializeField] private TextMeshProUGUI speedometer;  
  [SerializeField] private TextMeshProUGUI RPMmeter;  
  [SerializeField] private bool customCenterOfMass;
  [SerializeField] private GameObject centerOfMass;

  [SerializeField] private List<WheelCollider> allWheels;
  private int wheelsOnGround;
  

  void Start()
  {
    rigidBody = GetComponent<Rigidbody>();
    if (customCenterOfMass)
    {
      rigidBody.centerOfMass = centerOfMass.transform.position;
    }
  }


  private bool isOnGround()
  {
    wheelsOnGround = 0;
    foreach (var wheel in allWheels) 
    {
      if (wheel.isGrounded) { wheelsOnGround++; }
    }

    return wheelsOnGround == 4;
  }

  private void Update()
  {
    speed = Mathf.Round(rigidBody.velocity.magnitude * 3.6f);
                                    // This calculate to KM/s
    speedometer.text = "Speed: " + speed + "KM/h";
    RPMmeter.text = "RPM: " + (speed % 30) * 40;
  }

  // Update is called once per frame
  void FixedUpdate()
  {
    if (!isOnGround()) { return; }
    // Move the car forward
    GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * Input.GetAxis("Vertical") * horsePower);
    //this.transform.Translate(Vector3.forward * Time.deltaTime * speed * Input.GetAxis("Vertical"));
    this.transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * Input.GetAxis("Horizontal"));
  }
}

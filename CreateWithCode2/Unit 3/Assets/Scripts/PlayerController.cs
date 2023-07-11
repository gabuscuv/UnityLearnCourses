using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Exposable Variables
    public float jumpForce = 10;
    public float gravityModifer;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip jumpSound;
    public AudioClip crashSound;

    // Internal Use
    private Rigidbody playerRb;
    private Animator playerAnimator;
    private bool isGameOver;
    private bool isOnGround = true;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        playerRb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();

        Physics.gravity *= gravityModifer;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && ! isGameOver)
        {
            // Set GlobalState
            isOnGround = false;
            
            dirtParticle.Stop();
            audioSource.PlayOneShot(jumpSound, 1.0f);
            
            playerAnimator.SetTrigger("Jump_trig");
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Obstacule"))
        {
            // Set GlobalState
            isGameOver = true;
            
            // Disabling Particules
            explosionParticle.Play();
            dirtParticle.Stop();

            audioSource.PlayOneShot(crashSound, 1.0f);
            
            // Set Death Animations
            playerAnimator.SetBool("Death_b",true);
            playerAnimator.SetInteger("DeathType_int",1);
            
            //
            Debug.Log("Game Over!");
        }

        if (collision.gameObject.CompareTag("Ground")) 
        { 

            isOnGround = true;
            dirtParticle.Play();
        }

        //base.OnCollisionEnter(collision);
    }

    public bool GetIsGameOver()
    {
        return isGameOver;
    }

}

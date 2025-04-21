using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    private Rigidbody rb;
    [SerializeField] private float jumpForce;
    [SerializeField] private float gravityModifier = 9.8f;  
    [SerializeField] private Animator playeranim;

    private bool grounded = true; 
    public bool gameIsActive = true; 
    public ParticleSystem  explosionParticle;
    public AudioClip CrashSound; 
    public ParticleSystem dirtParticle;
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        Physics.gravity *= gravityModifier;  
        playeranim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && grounded && gameIsActive)
        {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        grounded = false;
        playeranim.SetTrigger("JumpTrig"); 
        dirtParticle.Stop();
        } 
    }
void OnCollisionEnter(Collision collision)
{
    if(collision.gameObject.CompareTag("Ground")) 
    {
        grounded = true; 
        dirtParticle.Play();
    }
    else if(collision.gameObject.CompareTag("Obstacle"))
    {
        gameIsActive = false; 
        Debug.Log("I just lost the game");
        playeranim.SetBool("Death_b", true); 
        playeranim.SetInteger("DeathType_int", 1);
        explosionParticle.Play(); 
        dirtParticle.Stop();


}
}
}

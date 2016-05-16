using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    //make RigidBody
    public Rigidbody rb;
    //speed of ball
    public float moveSpeed = 20.00f;

    // Set up the audio
    public AudioClip A1;
    public AudioClip A2;
    public AudioClip B1;
    public AudioClip B2;
    public AudioClip C1;
    public AudioClip C2;
    public AudioClip D1;
    public AudioClip D2;
    public AudioClip E1;
    public AudioClip E2;
    public AudioClip F1;
    public AudioClip F2;
    public AudioClip G1;
    public AudioClip G2;


    

	// Use this for initialization
	void Start () {
        // declare the RigidBody
        rb = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update () {
        
	
	}

    void FixedUpdate()
    {
        rb.MovePosition(transform.position + transform.forward * moveSpeed * Time.deltaTime);
    }


    //All check and call their block and function
    public void WhatBlock(Collider otherObject)
    {
       if (otherObject.tag == "BG")
        {
            // calls function in the sound manager to play AudioClip
            SoundContoller.Instance.RandomSFX(B1, B2);
            // Dont know why it wont call 
            //Commented out so I could Test Other Things first
            //otherObject.GetComponent<BlockGravity>().Grav;
        }
        else if (otherObject.tag == "BL")
        {
            // calls function in the sound manager to play AudioClip
            SoundContoller.Instance.RandomSFX(C1, C2);
            // Dont know why it wont call
            //Commented out so I could Test Other Things first
            //otherObject.GetComponent<BlockLeft>().Left;
        }
        else if (otherObject.tag == "BR")
        {
            // calls function in the sound manager to play AudioClip
            SoundContoller.Instance.RandomSFX(D1, D2);
            // Dont know why it wont call 
            //Commented out so I could Test Other Things first
            //otherObject.GetComponent<BlockRight>().Right;
        }
        else if (otherObject.tag == "BT")
        {
            // calls function in the sound manager to play AudioClip
            SoundContoller.Instance.RandomSFX(E1, E2);
            // Dont know why it wont call 
            //Commented out so I could Test Other Things first
            //otherObject.GetComponent<BlockTeleport>().Tele;
        }
        else if (otherObject.tag == "BS")
        {
            // calls function in the sound manager to play AudioClip
            SoundContoller.Instance.RandomSFX(G1, G2);
            // Dont know why it wont call 
            //Commented out so I could Test Other Things first
            //otherObject.GetComponent<BlockSlow>().Slow;
        }

    }

}

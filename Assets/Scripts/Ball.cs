using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    //public Vector3 ball;
    public Rigidbody rb;

    private float moveSpeed = 10.00f;
    

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update () {
        
	
	}

    void FixedUpdate()
    {
        rb.MovePosition(transform.position + transform.forward * moveSpeed * Time.deltaTime);
    }
}

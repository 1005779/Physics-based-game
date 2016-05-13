using UnityEngine;
using System.Collections;

public class BlockDown : BaseBlock {

    public GameObject ball;
    public Rigidbody rb;
    public


	// Use this for initialization
	void Start () {
        rb = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>().rb;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

   /* public void RotateBall(Transform rotation)
    {
        rb = rotation + 90;
    }*/

    public void OnTriggerEnter(Collider ball)
{
    rb.transform.rotation = rb + 90;
}
}

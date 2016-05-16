using UnityEngine;
using System.Collections;

public class BlockGravity : BaseBlock {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

   
    public void Grav()
    {
        
        float speed = 10.0f;
        GameObject grav;

        grav = GameObject.FindGameObjectWithTag("BG");
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, grav.transform.position, step);
    }
}

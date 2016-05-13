using UnityEngine;
using System.Collections;

public class BaseBlock : MonoBehaviour {

    public GameObject ball;

	// Use this for initialization
	void Start () {
        ball = GameObject.FindGameObjectWithTag("Ball");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}

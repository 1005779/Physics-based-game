﻿using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	
	}

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Ball")
        {
            Application.LoadLevel("WinLose");
        }
    }
}
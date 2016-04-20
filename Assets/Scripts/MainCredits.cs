using UnityEngine;
using System.Collections;

public class MainCredits : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //loads Credits Scene
        if (Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel("Credits");
        }
	
	}
}

using UnityEngine;
using System.Collections;

public class CreditsBack : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //Returns To Main Menue
        if (Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel("Main");
        }
	
	}
}

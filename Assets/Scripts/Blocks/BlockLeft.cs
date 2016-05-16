using UnityEngine;
using System.Collections;

public class BlockLeft : BaseBlock {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Left()
    {
        transform.rotation = Quaternion.AngleAxis(90, Vector3.left);
    }
}

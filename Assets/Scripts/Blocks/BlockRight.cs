using UnityEngine;
using System.Collections;

public class BlockRight : BaseBlock {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Right()
    {
        transform.rotation = Quaternion.AngleAxis(-90, Vector3.left);
    }
}

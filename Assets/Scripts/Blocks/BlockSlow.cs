using UnityEngine;
using System.Collections;

public class BlockSlow : BaseBlock {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Slow(float MoveSpeed)
    {
        MoveSpeed = MoveSpeed / 2;
    }
}

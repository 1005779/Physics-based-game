using UnityEngine;
using System.Collections;

public class BlockTeleporter : BaseBlock {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // When this function it checks for how many teleporters
    //Are in play, stores them, checks how mant there are then
    //moves the ball acordingly.
    public void Tele()
    {
        GameObject[] Teleporters = GameObject.FindGameObjectsWithTag("BT");
        int index;
        index = Random.Range(0, Teleporters.Length);

        if (Teleporters.Length > 2)
        {
            GameObject.FindGameObjectWithTag("Ball").transform.position = Teleporters[index].transform.position;
        }
        else if (Teleporters.Length == 2)
        {
            if (transform.position == Teleporters[0].transform.position)
            {
                GameObject.FindGameObjectWithTag("Ball").transform.position = Teleporters[1].transform.position;
            }
            else if (transform.position == Teleporters[1].transform.position)
            {
                GameObject.FindGameObjectWithTag("Ball").transform.position = Teleporters[0].transform.position;
            }
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class WinLoseButtons : MonoBehaviour {

    public EventSystem LevelEventSystem;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Main()
    {
        Application.LoadLevel("Main");
    }

    public void Replay()
    {
        Application.LoadLevel("Level-1");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}

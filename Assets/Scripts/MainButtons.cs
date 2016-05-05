using UnityEngine;
using System.Collections;

public class MainButtons : MonoBehaviour {

    public void Play()
    {
        Application.LoadLevel("Level-1");
    }

    public void Credits()
    {
        Application.LoadLevel("Credits");
    }

    public void Close()
    {
        Application.Quit();
        print("Quit");
    }
}

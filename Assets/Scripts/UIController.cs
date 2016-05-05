using UnityEngine;
using System.Collections;
//tell it to use event system
using UnityEngine.EventSystems;

public class UIController : MonoBehaviour {

    //public event system varible
    public EventSystem LevelEventSystem;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Has the user clicked the primary mouse button
        if (Input.GetMouseButtonDown(0))
        {
            //Is the cursor over the UI?
            if (LevelEventSystem.IsPointerOverGameObject())
            {
                Debug.Log("Over UI!");
            }
            else
            {
                //setup ray based on mouse possition
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                
                //Perform a raycast to determine what we have hit
                RaycastHit hitResults;
                if (Physics.Raycast(ray, out hitResults))
                {
                    //retrive the game obgect ray collided with
                    GameObject hitObject = hitResults.collider.gameObject;
                    
                    //attempting th retrive platform
                    Platform platform = hitObject.GetComponent<Platform>();
                    if (platform != null)
                    {
                        platform.ReactToMouseClick();
                    }
                    else
                    {
                        // Attempting to find platform from parent
                        platform = hitObject.GetComponentInParent<Platform>();
                        if (platform != null)
                        {
                            platform.ReactToMouseClick();
                        }
                    }
                }
            }
        }
	
	}
}

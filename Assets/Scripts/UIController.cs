using UnityEngine;
// Tell it to use UI
using UnityEngine.UI;
using System.Collections;
//tell it to use event system
using UnityEngine.EventSystems;

public class UIController : MonoBehaviour {

    // tracking the time and blocks used
    private float finalTime;
    private int blocksUsed;
    // Timer
    private float timeLeft;
    public float ballSpeed;

    // Texts for UI
    public Text FinalTime;
    public Text BlocksUsed;
    public Text TimeLeft;
    public Text BallSpeed;    

    //public event system varible
    public EventSystem LevelEventSystem;

	// Use this for initialization
	void Start () {
        // Timer
        timeLeft = 60.00f;
        // Tracking
        blocksUsed = 0;
        finalTime = 0.00f;

        //Texts in UI
        SetTextCalls();
	
	}
	
	// Update is called once per frame
	void Update () {

        ballSpeed = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>().moveSpeed;

        //Call Timer Function
        Timer();

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

    // Countdown timer - save final thime then load WinLose 
    public void Timer()
    {
        //count for blocks
        if (Input.GetMouseButtonDown(0))
        {
            blocksUsed = blocksUsed + 1;
        }

        //Counters
        finalTime += Time.deltaTime;
        timeLeft -= Time.deltaTime;

        //Texts in UI updates
        SetTextCalls();

        //Time runn out - end game
        if (timeLeft <= 0)
        {
            PlayerPrefs.SetFloat("Time: ", finalTime);
            Application.LoadLevel("WinLose");
        }

    }

    // Func to call the text lines
    public void SetTextCalls()
    {
        FinalTime.text = "Time: " + finalTime.ToString();
        BlocksUsed.text = "Blocks Used: " + blocksUsed.ToString();
        TimeLeft.text = "Time Left: " + timeLeft.ToString();
        BallSpeed.text = "Ball Speed: " + ballSpeed.ToString();

    }
}

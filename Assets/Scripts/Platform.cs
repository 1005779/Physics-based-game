using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Platform : MonoBehaviour
{
    // declaring new objects to tie to script
    public GameObject PrefabToSpawn;
    public GameObject AnchorPoint;

    // var to check if any blocks are already there
    private GameObject AttachedBuilding = null;

    // Declare Eventsys
    public EventSystem LevelEventSystem;

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Swap(GameObject Block)
    {
        PrefabToSpawn = Block;
    }

    public void ReactToMouseClick()
    {
        // Is there already a building?

        if (AttachedBuilding != null)
        {
            // If Building is there then destroy it and set to null
            GameObject.Destroy(AttachedBuilding);
            AttachedBuilding = null;
        }
        else
        {
            // Spawn the new Prefab
            AttachedBuilding = GameObject.Instantiate(PrefabToSpawn);

            // Possition the Prefab at the anchor point
            AttachedBuilding.transform.position = AnchorPoint.transform.position;
            AttachedBuilding.transform.SetParent(AnchorPoint.transform);
        }
    }
       

    }






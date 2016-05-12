using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour
{

    public GameObject AnchorPoint;
    public GameObject PrefabToSpawn;

    // Set the AttachedBuilding as different prefabs IE teleporter, up, down, left, right, and my own ones somehow 
    //ask Blenderhip Cuecumbercap how he did it
    private GameObject AttachedBuilding = null;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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

using UnityEngine;
using System.Collections;

public class placeblock : MonoBehaviour {

    //public RaycastHit hit = new RaycastHit();
    public Vector3 mousePosition { get; set; }
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	
	}

    /*if ((Input.GetMouseButtonDown (0) && hit.transform.tag == "TowerPlatform") == true) {
	  hit.transform.GetComponent<TowerPlatform>().placeTower (towers[towerSelection], towersCost[towerSelection]);
			}
		}*/

    public void CanPlace( bool place)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

      if (Physics.Raycast (ray, out hit))
      {
        mousePosition = hit.point;
         Debug.DrawLine (Camera.main.transform.position, mousePosition, Color.green);
         
    //left click - place block
         if ((Input.GetMouseButtonDown(0) && hit.transform.tag == "GridBlock") == true)
         {
             
         }
      
      }

    }


    
}

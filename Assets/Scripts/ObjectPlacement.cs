using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectPlacement : MonoBehaviour
{
    public Transform objectToPlace;
    public bool objectIsPlaced = false;
    public Toggle UI_toggle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == objectToPlace.gameObject)
        {
            UI_toggle.isOn = true;
            objectIsPlaced = true;
            Debug.Log("Object is placed");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject == objectToPlace.gameObject)
        {
            UI_toggle.isOn = false;
            objectIsPlaced = false;
            Debug.Log("Object is removed");
        }
    }
}

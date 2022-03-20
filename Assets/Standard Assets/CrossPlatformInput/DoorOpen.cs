using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject DoorTrigger;

    private void OnTriggerEnter() 
    {
        DoorTrigger.GetComponent<Animation>().Play("door");
    }
}

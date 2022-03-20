using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{

    public GameObject TrapDoor;

    void OnTriggerEnter()
    {
        TrapDoor.GetComponent<Animation>().Play("Trap1");
    }

}

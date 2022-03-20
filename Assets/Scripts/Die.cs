using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    //[SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag("Player"))
        {
            col.collider.GetComponent<Rigidbody>().position = respawnPoint.position;
        }
    }
}

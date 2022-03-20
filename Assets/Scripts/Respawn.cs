using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //other.transform.position = new Vector3(0, 2, -20);
        if (other.gameObject.CompareTag("Respawn"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

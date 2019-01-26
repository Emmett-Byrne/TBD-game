using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject door;

    void OnTriggerEnter(Collider col)
    {
        print("TEST");
        if (col.gameObject.tag == "Player")
        {
            door.SetActive(true);
        }
    }
}


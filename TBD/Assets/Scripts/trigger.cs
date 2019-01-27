using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
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


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject door;
  //  private Rigidbody rb;

    float angle = -33f;

    void Start()
    {
   //     rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            door.SetActive(true);
   //         rb.rotation.eulerAngles.Set(0.617f, -4.102f, -33.671f);
        }
    }
}

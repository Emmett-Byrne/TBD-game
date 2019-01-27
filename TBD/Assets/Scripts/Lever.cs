using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject door;
    public GameObject lever;
    //  private Rigidbody rb;

    void Start()
    {
   //     rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            door.SetActive(true);
            lever.transform.Rotate(0f, 0f, -60f);
   //         rb.rotation.eulerAngles.Set(0.617f, -4.102f, -33.671f);
        }
    }
}

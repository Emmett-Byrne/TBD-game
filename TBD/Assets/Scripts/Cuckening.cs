using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuckening : MonoBehaviour
{
    public GameObject sphere;
    public GameObject block;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            sphere.transform.Translate(Vector3.forward * Time.deltaTime);
        }
        if (other.tag == "GameController")
        {
            if (block.transform.position.y < 20.5f)
            {
                block.transform.Translate(Vector3.down * Time.deltaTime);
            }
            else
            {
                block.transform.Translate(Vector3.down * 1);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public float speed = 10.0f;
    float jump = 0.0f;
    bool isGrounded = false;
    public GameObject door;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    private void onTriggerEnter()
    {
        door.SetActive(true);
    }

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    void Update()
    { 
        if (Input.GetKey(KeyCode.Space) && isGrounded == true)
        {
            jump = 10f;
            isGrounded = false;
        }
        else
        {
            jump = 0f;
        }
    }

    void FixedUpdate()
    {
        float moveHori = Input.GetAxis("Horizontal");
        // float moveVerti = Input.GetAxis("Vertical");


        Vector3 movement = new Vector3(moveHori, jump, 0.0f) * speed;

        rb.AddForce(movement);
    }
}

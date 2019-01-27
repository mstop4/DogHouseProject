using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrResetPos : MonoBehaviour {

    protected Vector3 offset;
    protected Rigidbody rb;
    public Transform anchor;

    public float speed;
    public KeyCode key;

    // Use this for initialization
    void Start () {
        offset = transform.position - anchor.transform.position;
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(key))
        {
            Vector3 directionToMove = offset - transform.position;
            float distance = Vector3.Distance(transform.position, offset);
            if (distance > 0.7f)
            {
                //transform.position = transform.position + directionToMove * speed * Time.deltaTime;
                rb.AddForce(directionToMove.normalized * Time.deltaTime*5000);
                rb.velocity = Vector3.ClampMagnitude(rb.velocity, speed);

            }

        }

	}
}

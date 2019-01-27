using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringController : MonoBehaviour {

    public Transform anchor;
    public float speed = 0.1f;
    public KeyCode key;

    // Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(key))
        {
            Vector3 directionToMove = anchor.transform.position - transform.position;
            //float distance = Vector3.Distance(transform.position, anchor.transform.position);
            //if(distance > 0.7f)
            transform.position = transform.position + directionToMove * speed;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matchPosition : MonoBehaviour {

    public Vector3 offset;
    public Transform anchor;

	// Use this for initialization
	void Start () {
        offset = transform.position - anchor.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 newPos = anchor.transform.position + offset;
        transform.position = newPos;//new Vector3(newPos.x, newPos.y, transform.position.z);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignChild : MonoBehaviour {

    public Transform child;

	// Use this for initialization
	void Start () {
        child.parent = transform;
	}
	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScrOwnerController : MonoBehaviour {
	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}

	public void IsBack () {
		print("Is back");
		anim.SetBool("isBack", true);
	}
}

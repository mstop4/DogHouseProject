using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

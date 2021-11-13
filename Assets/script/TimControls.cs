using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimControls : MonoBehaviour {

	static Animator anim ;
	// Use this for initialization
	void Start () {
		anim =GetComponent<Animator>() ;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow)) ;
		{
			anim.SetTrigger("isWalking");
		}

	}
}

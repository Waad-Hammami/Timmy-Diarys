using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collison : MonoBehaviour {

	void OnCollisionEnter(Collision gameObjectInformation)
	{
		if (gameObjectInformation.gameObject.name == "Ch09_nonPBR")
		{
			Debug.Log("Collision Detected");
			SceneManager.LoadScene("QA1");
		}
	}
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Correct : MonoBehaviour {

	public void Skip()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

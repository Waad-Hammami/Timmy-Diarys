using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class nextbutton : MonoBehaviour {


	public void PlayGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

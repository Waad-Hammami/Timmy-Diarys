using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Qtrigger : MonoBehaviour {

	#region Attriibutes 
	

    #endregion
    #region Monobehaviour API
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	 
		
        
    }
	private void OntriggerEnter(Collider other)
		{
			if(other.tag== "Player")
			{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			}
		}
	#endregion
}

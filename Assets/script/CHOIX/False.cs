using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class False : MonoBehaviour {

	public int maxHealth = 3;
	public int currentHealth;
	public HealthBar Healthbar;
	



	public void PlayGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		TakeDamage(1);

	}

	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
		Healthbar.SetMaxHealth(maxHealth);
	}

	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		Healthbar.SetHealth(currentHealth);
	} 
	// Update is called once per frame
	void Update () {
		

	}
}

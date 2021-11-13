using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.UI;


public class AudioManager : MonoBehaviour {

	public Sound[] sounds;




	void Update () {
		if(Input.GetButton ("OptionButton")){

			GetComponent<AudioSource>().Stop();

		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player12 : MonoBehaviour
{
    private Animator animations;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        animations = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {         
            gameObject.transform.Translate(0, 0, speed);
            animations.SetBool("walk", true);
            animations.SetBool("idle", false);
            gameObject.GetComponent<AudioSource>().enabled = true;
        }
      
        if (Input.GetKey(KeyCode.Q))
        {
            gameObject.transform.Translate(-speed, 0,0 );
            animations.SetBool("Walk", true);
            animations.SetBool("Idle", false);
            gameObject.GetComponent<AudioSource>().enabled = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(speed,0, 0);
            animations.SetBool("Walk", true);
            animations.SetBool("Idle", false);
            gameObject.GetComponent<AudioSource>().enabled = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(0, 0, -speed);
            animations.SetBool("Walk", true);
            animations.SetBool("Idle", false);
            gameObject.GetComponent<AudioSource>().enabled=true;

        }
        if (!Input.anyKey)
        {
            animations.SetBool("Walk", false);
            animations.SetBool("Idle", true);

            gameObject.GetComponent<AudioSource>().enabled = false;


        }
    }
  
}

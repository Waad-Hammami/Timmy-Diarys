using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Animator animations;
    public float speed;
    public Slider health;
    public GameObject menu;
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
            animations.SetBool("Attack", false);
            animations.SetBool("Idle", false);
            animations.SetBool("Death", false);

            if (Input.GetKey(KeyCode.R))
            {
                animations.SetBool("Walk", false);
                animations.SetBool("Run", true);
                gameObject.transform.Translate(0, 0, speed * 3);

            }
            else
            {
                gameObject.transform.Translate(0, 0, speed);
                animations.SetBool("Walk", true);
                animations.SetBool("Run", false);
            }

            if (health.value == 0)
            {
                animations.SetBool("Death", true);
                gameObject.tag = "Dead";
                menu.SetActive(true);
            }
            else
            {
                if (!Input.anyKey)
                {
                    animations.SetBool("Idle", true);
                    animations.SetBool("Run", false);
                    animations.SetBool("Walk", false);
                    animations.SetBool("Death", false);

                }
            }
            if (Input.GetKey(KeyCode.Mouse0))
            {
                animations.SetBool("Walk", false);
                animations.SetBool("Wave", true);
                animations.SetBool("Run", false);
                animations.SetBool("Idle", false);
                animations.SetBool("Death", false);

            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anime1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var animator = GameObject.Find("Sphere").GetComponent
            <Animator>();
        float speed = animator.GetFloat("speed");

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            speed += 0.5f;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            speed -= 0.5f;


        }

        animator.SetFloat("speed",speed);
    }
}

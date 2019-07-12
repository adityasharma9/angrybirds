using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunanimscript : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            anim.Play("scope");
        }
        else if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            anim.Play("idle");
        }
    }
}

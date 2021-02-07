using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public Animator anim;

    public string boolName;
    public string boolName2;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            anim.SetBool(boolName, true);
            
        }
        else
        {
            anim.SetBool(boolName, false);
            anim.SetBool(boolName2, false);
        }

        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool(boolName2, true);
        }
        else
        {
            anim.SetBool(boolName2, false);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemebt : MonoBehaviour
{
    private bool onGround;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(onGround)
        {
            if(Input.GetButton("Jump"))
            {

            }
        }
    }

    void FixedUpdate()
    {

    }
}

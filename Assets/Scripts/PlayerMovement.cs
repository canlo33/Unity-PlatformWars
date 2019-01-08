using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private bool onGround;
    private Rigidbody rigidBody;
    private float jumpPressure;
    public float minJump;
    public float maxJump;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        onGround = true;
        jumpPressure = 0f;
        minJump = 5f;
        maxJump = 10f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        // ! Jump {
        // Charged Jump 
        if(onGround)
        {
            if(Input.GetButton("Jump"))
            {
                if(jumpPressure < maxJump)
                {
                    jumpPressure += Time.deltaTime * 6f;
                }
                else
                {
                    jumpPressure = maxJump;
                }
               
                
            }

            // Regular Jump

        else
            {
                if(jumpPressure > 0f)
                {
                    jumpPressure += minJump;
                    Jump();
                }
                
            }
        }

        // ! Jump }
    }


    private void OnCollisionEnter(Collision collider)
    {
       if(collider.gameObject.CompareTag("ground"))
        {
            onGround = true;
        }
    }

    void Jump()
    {
        rigidBody.velocity = new Vector3(0f, jumpPressure, 0f);
        jumpPressure = 0f;
        onGround = false;
    }
  


}

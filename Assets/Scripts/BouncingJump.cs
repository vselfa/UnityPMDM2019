using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;  // For the Texdt class
using System;  // For the String class 


public class BouncingJump : MonoBehaviour {
   // Jumping until stop

    // float: to decrease in 0.1 each frame
    public float initJumpValue = 5.0f;   
    private float jumpValue;    
    private Rigidbody rigidBody;
    private bool start = false;
    public Text missatge;  

    // Start is called before the first frame update
    void Start()    {
        rigidBody = GetComponent<Rigidbody>();  
        ShowText ("Starting"); 
    }

   void Update () {
        if (Input.GetButtonDown("Jump") ){
            start = true;
            jumpValue = initJumpValue;
            ShowText ("Jumping"); 
        }
        if (start) {
            // Jumping and arriving at ground
            if (Mathf.Abs (rigidBody.velocity.y) < 0.01f )  {
                jumpValue -= initJumpValue / 4;  // 4 bouncnings
                ShowText ("Bouncing"); 
                rigidBody.AddForce(Vector3.up * jumpValue, ForceMode.Impulse);
            }
            if (jumpValue < 0.0f)  start = false;
        }
    }
    void ShowText(String aux ) {
        missatge.text = aux;
    }


}
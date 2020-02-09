using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // For the Text class

using System;  // For the String class 

public class Move : MonoBehaviour {
   public float speed = 2f;
   public float forceValue = 10f; 
   private Rigidbody rigidBody;  // 1.- The private variable

   // public Text missatge;
   public Text message; 
   private int numCollisions = 0;
   private AudioSource audioSource;
  
   // Use this for initialization
   void Start () {
      // 2.- Accessing to the RigidBody component of the object: Only on time!
 	   rigidBody = GetComponent<Rigidbody>();  
      // Showing a text into the console
      Debug.Log("Starting the game -------------------");
      audioSource = GetComponent<AudioSource>();
   } 

   // Update is called once per frame
   void Update () {
      // 3.- Using rigidBody every time. Pay attention to the mass of the object!
      if (Input.GetAxis("Horizontal") != 0 ) {
         // ShowText= "Moving with Left / Right arrows";
      }
      if (Input.GetAxis("Vertical") != 0) {
         // ShowText = "Moving with Up / Down arrows";
      }
           
      rigidBody.AddForce(new Vector3 ( Input.GetAxis("Horizontal")* forceValue,
                                       0, 
                                       Input.GetAxis("Vertical")* forceValue ) );
   }

   void OnCollisionEnter(Collision other) {
        numCollisions++;
        ShowText("Collision number: " + numCollisions);
        audioSource.Play();
        if (other.gameObject.tag == "Door") {
            ShowText("Collision to the door");
        }
    }

    void ShowText(String aux ) {
        message.text = aux;
    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // For the Text class
using System;  // For the String class 

public class DetectCollision : MonoBehaviour {

    // The attribute to control the text
    public Text missatge;
    private int numCollisions = 0;

    // Start is called before the first frame update
    void Start()    
    {
        ShowText("Start ...");
    }
    
    // Update is called once per frame
    void Update()     {     }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Border")   {
            ShowText("Danger: Near the border!!");
            print("Danger: Near the border!!!!");
        }
    }
    

    void OnCollisionEnter(Collision other) {
        numCollisions++;
        // ShowText("Collision! " + numCollisions);
        if (other.gameObject.tag == "Door") {
            // ShowText("Collision to the Door");
        }
    }


    void ShowText(String aux ) {
        missatge.text = aux;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;  // For the Text class
using System;  // For the String class 

public class OpenDoor : MonoBehaviour {
    private GameObject porta;  // The públic variable
    public Text missatge;

    void Start()     {   
        porta = GameObject.FindWithTag("Door");
    }

    // Update is called once per frame
    void Update()    {      }

    void OnCollisionEnter(Collision other) {
        ShowText("OnCollisionEnter");
        // We have just collisioned with the “Open” tag
        if (other.gameObject.tag == "OpenDoorTag")  { 
            // Open the door 
	        porta.transform.Rotate(0, 90, 0); 
            //porta.SendMessage("Play");
            ShowText("Door open");
        }
        if (other.gameObject.tag == "CloseDoor")
        {    // Getting the name to close the door
            porta.transform.Rotate(0, 90, 0); 
            //porta.SendMessage("Play");
            ShowText("Door open");
        }

    }

    void ShowText(String aux ) {
        missatge.text = aux;
    }
}

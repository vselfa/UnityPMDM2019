using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// New includes
using System;  // For the class String
using UnityEngine.UI;  // For the Text class

public class showText : MonoBehaviour  {
   // The attribute to control the text
   public Text missatge;
   // Use this for initialization
   void Start () {
	    missatge = GetComponent<Text>();
        // Showing a text
       	missatge.text = "Start";
    }
}


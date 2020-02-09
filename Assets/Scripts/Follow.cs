using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {
    
    // To follow an object keeping an offset distance
    public GameObject target; // The object to follow
    private Vector3 offset;  // The distance

    void Start () {  
	    offset = transform.position - target.transform.position; 	
    }
    
    // To move the camera AFTER moving the sphere 
    void LateUpdate()  { 
        // To update the position of the camera AFTER the update of the sphere
        transform.position = target.transform.position + offset;
    }
}

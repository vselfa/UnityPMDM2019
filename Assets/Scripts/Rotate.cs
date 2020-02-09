using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate one degree per second
        //transform.Rotate(0, Input.GetAxis("Horizontal"),Input.GetAxis("Horizontal"));
        // Rotate one degree per second on the X axis
        transform.Rotate(Time.deltaTime, 0, 0);
         
    }
}

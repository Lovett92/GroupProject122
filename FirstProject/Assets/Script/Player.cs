using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if space key is pressed down
        if(Input.GetKeyDowm(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 5 , ForceMode.VelocityChange);
        }
    }
}

private void FixedUpdate()
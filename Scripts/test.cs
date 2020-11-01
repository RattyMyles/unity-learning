using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{	
	Rigidbody rb;
	
    // Start is called before the first frame update
    void Start()
    {	
		// The destroy fuction will delete the game object, the 3f is a 3 second float it will delete.
		//
        //Destroy(gameObject,3f);
		
		rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		// If user clicks space, delete object
        if (Input.GetKeyDown(KeyCode.Space))
		{
			//Destroy(gameObject);
			
			//Jump when you press space by adding force
			//rb.AddForce(Vector3.up * 500);
			
			rb.velocity = Vector3.forward * 20f;
		}
    }
	
	private void OnMouseDown()
	{
		// On mouse click, it will delete the cube
		//Destroy(gameObject,3f);
	}
}

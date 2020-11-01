using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{	
	Rigidbody rb;
	
	// initiate game object of wintext
	public GameObject winText;
	
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
			
			// it will go forward but be aware of the constraints in unity of the physics compononent
			//rb.velocity = Vector3.forward * 20f;
			
		}
		// Initiate new level or scene.
		if (Input.GetKeyDown(KeyCode.R))
			{
				SceneManager.LoadScene("level2");	
			}
    }
	// on click of a mouse, do action
	private void OnMouseDown()
	{
		// On mouse click, it will delete the cube
		//Destroy(gameObject,3f);
	}
	
	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag == "Enemy")
		{	
			// If object collides with the game object, destroy it!
			//Destroy(gameObject);
			
			// If object collides with game object, destroy object instead!
			Destroy(collision.gameObject);
			
			winText.SetActive(true);
		}
	}
	
}


using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	
	void FixedUpdate () {
		
		if(Input.GetKey(KeyCode.UpArrow))
			
			if(Input.GetKeyDown(KeyCode.RightArrow))
				
				transform.position = new Vector3(transform.position.x - 1f, transform.position.y + 1, transform.position.z);
		
		
		
		
		if (Input.GetKey(KeyCode.UpArrow) && Input.GetKeyDown(KeyCode.LeftArrow))
			
			transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z - 1f);
		
		
		
		
		if (Input.GetKey(KeyCode.DownArrow) && Input.GetKeyDown(KeyCode.RightArrow))
			
			transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z + 1f);
		
		
		
		
		if (Input.GetKey(KeyCode.DownArrow) && Input.GetKeyDown(KeyCode.LeftArrow))
			
			transform.position = new Vector3(transform.position.x + 1, transform.position.y - 1, transform.position.z);
		
	}
}

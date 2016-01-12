using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	[SerializeField] float speed;
	
	float h;
	float v;
	//Rigidbody player;
	
	void Awake ()
	{
		//player = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate ()
	{
		h = Input.GetAxisRaw("Horizontal");
		v = Input.GetAxisRaw("Vertical");
		
		
		Move (h, v);
	}
	
	void Move (float h, float v)
	{
	
		if (Input.GetKeyDown(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow))
		{
			transform.position = new Vector3 (Mathf.Round(transform.position.x + 1), Mathf.Round(transform.position.y + v),
				Mathf.Round(transform.position.z));
				
		}
		else if (Input.GetKeyDown(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow))
		{
			transform.position = new Vector3 (Mathf.Round(transform.position.x), Mathf.Round(transform.position.y + v),
			    Mathf.Round(transform.position.z - 1));
		}
		
		else if (Input.GetKeyDown(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow))
		{
			transform.position = new Vector3 (Mathf.Round(transform.position.x), Mathf.Round(transform.position.y + v),
			    Mathf.Round(transform.position.z + 1));
		}
		else if (Input.GetKeyDown(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow))
		{
			transform.position = new Vector3 (Mathf.Round(transform.position.x - 1), Mathf.Round(transform.position.y + v),
			    Mathf.Round(transform.position.z));
		}
		
	}
	
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Tile")
		{
			other.GetComponent<SpriteRenderer>().enabled = true;
			other.enabled = false;
			Score.score += 25;
			Score.count += 1;
		}
	}
	
	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.name == "Ground")
		{
			GameObject.Destroy(gameObject);
		}
	}
}


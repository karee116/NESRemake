using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	[SerializeField] float speed;
	// [SerializeField] Transform[] points;
	
	public float h;
	public float v;
	//Rigidbody player;
	Vector3 current;
	
	void Awake ()
	{
		current = transform.position;
		//player = GetComponent<Rigidbody>();
	}
	
	void Update ()
	{
		h = Input.GetAxisRaw("Horizontal");
		v = Input.GetAxisRaw("Vertical");
		
		
		Move (h, v);
	}
	
	void LateUpdate ()
	{
	}
	
	void Move (float h, float v)
	{
	
		if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow))
		{
			transform.position = new Vector3 (Mathf.Round(transform.position.x + h), Mathf.Round(transform.position.y + v),
				Mathf.Round(transform.position.z));
				
		}
		else if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow))
		{
			transform.position = new Vector3 (Mathf.Round(transform.position.x + h), Mathf.Round(transform.position.y + v),
			    Mathf.Round(transform.position.z));
		}
		
		else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow))
		{
			transform.position = new Vector3 (Mathf.Round(transform.position.x), Mathf.Round(transform.position.y + v),
			    Mathf.Round(transform.position.z + h));
		}
		else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow))
		{
			transform.position = new Vector3 (Mathf.Round(transform.position.x), Mathf.Round(transform.position.y + v),
			    Mathf.Round(transform.position.z + h));
		}
//		movement.Set ( v, h, -h);
//		movement = movement.normalized * speed * Time.deltaTime;
//		transform.position = new Vector3 (Mathf.Round(current.x + -h),
//			Mathf.Round(current.y + v),
//			Mathf.Round(current.z + -v));
		

	}
}

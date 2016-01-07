using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	[SerializeField] float speed;
	// [SerializeField] Transform[] points;
	
	float h;
	float v;
	//Rigidbody player;
	Vector3 movement;
	
	void Awake ()
	{
		//player = GetComponent<Rigidbody>();
	}
	
	void Update ()
	{
		h = Input.GetAxisRaw("Horizontal");
		v = Input.GetAxisRaw("Vertical");
		
		Move (h, v);
	}
	
	void Move (float h, float v)
	{
		Vector3 current = transform.position;
//		movement.Set ( v, h, -h);
//		movement = movement.normalized * speed * Time.deltaTime;
		transform.position = new Vector3 (Mathf.Round(current.x * v),
			Mathf.Round(current.y * h),
			Mathf.Round(current.z * -h));
	}
}

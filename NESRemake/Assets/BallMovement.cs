using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

	[SerializeField] float speed;
	
	void Start()
	{
		InvokeRepeating("Move", 1, 1);
	}
	
	void Move ()
	{
		Vector3 end = new Vector3 (transform.position.x, 
		               transform.position.y - 1,
		               transform.position.z + 1);
		               
		transform.position = Vector3.Lerp(transform.position, end, 1);
	}
	
	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.name == "Ground")
		{
			GameObject.Destroy(gameObject);
		}
		
		if (coll.gameObject.tag == "Player")
		{
			GameObject.Destroy(coll.gameObject);
		}
	}
}

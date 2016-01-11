using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	GameObject[] tiles;
	float score;
	
	void Awake()
	{
		tiles = GameObject.FindGameObjectsWithTag("Tile");
		score = 0;
	}
	
	void Update ()
	{
		foreach (var plate in tiles) {
			if (plate.GetComponent<SpriteRenderer>().enabled)
			{
				score += 25;
			}
		}
	}
}

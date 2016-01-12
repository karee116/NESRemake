using UnityEngine;
using System.Collections;

public class BallSpawn : MonoBehaviour {

	[SerializeField] GameObject enemy; // reference to an enemy
	[SerializeField] float spawnTime = 3f; // time it takes for enemy to spawn
	[SerializeField] Transform[] spawnPoints; // places where enemies can spawn
	
	void Start () // Sets a variable for myTime such that the spanwtime of an enemy changes 
		// over time
	{
//		float myTime = Time.timeSinceLevelLoad;
//		
//		if ( myTime < 5) {
//			InvokeRepeating ("Spawn", spawnTime * 5, spawnTime);
//		} else if (15 < myTime && myTime < 30) {
//			InvokeRepeating ("Spawn", spawnTime * 3, spawnTime);
//		} else if (30 < myTime && myTime < 45) {
			InvokeRepeating ("Spawn", spawnTime, spawnTime);
//		} else if (45 < myTime && myTime < 60) {
//			InvokeRepeating ("Spawn", spawnTime / 3, spawnTime);
//		} else if (60 < myTime) {
//			InvokeRepeating ("Spawn", spawnTime / 5, spawnTime);
//		}
		
	}
	
	
	void Spawn () // spawns an enemy at a random spawn point as long as the player is alive
	{
		int spawnPointIndex = Random.Range (0, spawnPoints.Length); // Different places to spawn based on
		// how many places are available
		
		Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}
}

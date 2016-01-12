using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public static float score;
	Text text;
	Text level;
	public static int count;
	
	void Awake()
	{
		text = GameObject.Find("ScoreText").GetComponent<Text>();
		level = GameObject.Find("LevelText").GetComponent<Text>();
		score = 0;
		count = 0;
	}
	
	void Update ()
	{
		text.text = "Score: " + score;
		if (count == 28)
		{
			level.text = "Level Cleared!";
		}
	}
}

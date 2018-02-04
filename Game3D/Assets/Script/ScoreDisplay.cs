using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreDisplay : MonoBehaviour {
	private Text txtScore;

	// Use this for initialization
	void Awake () {
		txtScore = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(GameManager.instance != null)
			txtScore.text = "Score: " + GameManager.instance.getScore(); 
	}
}

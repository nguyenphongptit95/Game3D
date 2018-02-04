using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	private int score;

	void Awake () {
		if (instance == null) {
			instance = this;
		} else {
			Destroy (gameObject);
		}			
	}

	void Start(){
		DontDestroyOnLoad (instance);
	}

	public void resetScore(){
		score = 0;
	}

	public int getScore(){
		return score;
	}

	public void addScore(){
		AudioManager.instance.coinSound ();
		score++;
	}

	void Update () {
	
	}
}

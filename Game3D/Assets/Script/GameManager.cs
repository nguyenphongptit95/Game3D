using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public static int moveMap = 0; // -1 - left 1 right
	public static int seeFar = 30;
	public static int seeWidth = 10;
	public static int seeHeight = 5;
	public static float loopTimeOpt = 1f;
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

	public void newGame(){
		CoinSpawner.reset ();//
		GroundBlockSpawner.reset ();//
		JumpPadSpawner.reset ();//
		resetScore ();//
		RamieSpawner.reset();
		BlackGhostSpawner.reset ();
		TruSpawner.reset ();
	}

	public void finish(){
		StartCoroutine (iEFinish());
	}

	IEnumerator iEFinish(){
		yield return new WaitForSeconds (6);
		SceneManager.LoadScene("MainMenu");
	}
}

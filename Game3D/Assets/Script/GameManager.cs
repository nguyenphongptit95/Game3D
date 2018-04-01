using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public static int moveMap = 0; // -1 - left 1 right
	public static int seeFar = 25;
	public static int seeWidth = 5;
	public static int seeHeight = 5;
	public static float loopTimeOpt = 1f;
	public static int map = 1;
	public static int life = 3;
	private int score;

	void Awake () {
		if (instance == null) {
			instance = this;
			life = 3;
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

	public void newGame(int map){
		CoinSpawner.reset ();//
		GroundBlockSpawner.reset ();//
		JumpPadSpawner.reset ();//
		resetScore ();//
		RamieSpawner.reset();
		BlackGhostSpawner.reset ();
		TruSpawner.reset ();
		GameManager.map = map;
	}

	public void finish(){
		StartCoroutine (iEFinish());
	}

	IEnumerator iEFinish(){
		yield return new WaitForSeconds (6);
		SceneManager.LoadScene("QuaMan");
	}
}

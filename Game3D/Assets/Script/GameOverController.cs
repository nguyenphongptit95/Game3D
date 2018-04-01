using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour {
	public void _ReStart(){
		GameManager.instance.newGame (GameManager.map);
		string scence = "GamePlay" + GameManager.map;
		SceneManager.LoadScene (scence);
	}

	public void _MainMenu(){
		GameManager.life = 3;
		SceneManager.LoadScene ("MainMenu");
	}

	public void _Next(){
		GameManager.map++;
		_ReStart ();
	}
}

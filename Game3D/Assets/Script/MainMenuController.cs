using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MainMenuController : MonoBehaviour {
	public void _Start(){
		CoinSpawner.reset ();
		GroundBlockSpawner.reset ();
		JumpPadSpawner.reset ();
		SceneManager.LoadScene ("GamePlay");
	}
	public void _Quit(){
		Application.Quit ();
	}

}

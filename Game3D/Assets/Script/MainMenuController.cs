using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MainMenuController : MonoBehaviour {
	public void _Start(){
		GameManager.instance.newGame ();
		SceneManager.LoadScene ("GamePlay");
	}
	public void _Start2(){
		GameManager.instance.newGame ();
		SceneManager.LoadScene ("GamePlay2");
	}
	public void _Quit(){
		Application.Quit ();
	}

}

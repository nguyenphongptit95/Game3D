using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MainMenuController : MonoBehaviour {
	public void _Start(int map){
		GameManager.instance.newGame (map);
		string scence = "GamePlay" + map;
		SceneManager.LoadScene (scence);
	}
	public void _Quit(){
		Application.Quit ();
	}

}

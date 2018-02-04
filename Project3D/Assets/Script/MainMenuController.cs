using UnityEngine;
using System.Collections;

public class MainMenuController : MonoBehaviour {
	public void _Start(){
		Application.LoadLevel ("GamePlay");
	}
	public void _Quit(){
		Application.Quit ();
	}

}

using UnityEngine;
using System.Collections;

public class Tru : MonoBehaviour {
	public bool isActive;
	void Awake(){
		TruSpawner.add (this);
		hide ();
	}


	public bool getActive(){
		return isActive;
	}

	public void hide(){
		gameObject.SetActive (false);
		isActive = false;
	}

	public void appear(){
		gameObject.SetActive (true);
		isActive = true;
	}
}

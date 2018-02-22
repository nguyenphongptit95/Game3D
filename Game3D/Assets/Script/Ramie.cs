using UnityEngine;
using System.Collections;

public class Ramie : MonoBehaviour {
	public bool isActive;
	void Awake(){
		RamieSpawner.add (this);
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

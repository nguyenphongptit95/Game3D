using UnityEngine;
using System.Collections;

public class GroundBlock : MonoBehaviour {

	public bool isActive;

	void Awake(){
		GroundBlockSpawner.add (this);
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

using UnityEngine;
using System.Collections;

public class BlackGhost : MonoBehaviour {
	float yMin;
	float yMax;
	float vel;
	float range = .5f;
	bool moveUp = true;
	public bool isActive;

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
	// Use this for initialization
	void Awake () {
		vel = .5f;
		Vector3 v3Position = gameObject.transform.localPosition;
		yMin = v3Position.y - range;
		yMax = v3Position.y + range;
		BlackGhostSpawner.add (this);
		hide ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 v3Position = gameObject.transform.localPosition;
		if(v3Position.y > yMax){
			moveUp = false;
		}else if(v3Position.y < yMin){
			moveUp = true;
		}

		if(moveUp){
			v3Position.y += vel * Time.deltaTime;
		}else{
			v3Position.y -= vel * Time.deltaTime;	
		}
		gameObject.transform.localPosition = v3Position;
	}
}

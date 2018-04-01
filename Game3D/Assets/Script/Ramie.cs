using UnityEngine;
using System.Collections;

public class Ramie : MonoBehaviour {
	public bool isActive;	
	private float maxY;
	private float minY; 
	[SerializeField]
	private float rangeY = .5f;
	[SerializeField]
	private float speed = 1f;
	private bool _moveUp;
	void Awake(){
		RamieSpawner.add (this);
		maxY = gameObject.transform.localPosition.y;
		minY = maxY - rangeY;
		_moveUp = false;
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

	void moveDown(){
		if (!_moveUp) {
			Vector3 v3 = gameObject.transform.localPosition;
			v3.y -= speed * Time.deltaTime;
			gameObject.transform.localPosition = v3;
			if (v3.y < minY)
				_moveUp = true;
		}
	}


	void moveUp(){
		if (_moveUp) {
			Vector3 v3 = gameObject.transform.localPosition;
			v3.y += speed * Time.deltaTime;
			gameObject.transform.localPosition = v3;
			if (v3.y > maxY)
				_moveUp = false;
		}
	}

	void Update () {
		moveUp ();
		moveDown ();
	}
}

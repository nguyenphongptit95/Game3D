using UnityEngine;
using System.Collections;

public class BanChong : MonoBehaviour {

	private float maxY;
	private float minY; 
	[SerializeField]
	private float rangeY;
	[SerializeField]
	private float speed;
	private bool _moveUp;

	void Awake () {
		maxY = gameObject.transform.localPosition.y;
		minY = maxY - rangeY;
		_moveUp = false;
	}

	void Update () {
		moveUp ();
		moveDown ();
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
}

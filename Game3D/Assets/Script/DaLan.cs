using UnityEngine;
using System.Collections;

public class DaLan : MonoBehaviour {

	private Rigidbody myBody;
	[SerializeField]
	private int myType;
	[SerializeField]
	private float maxVel;
	[SerializeField]
	private float speed;
	void Awake () {
		myBody = gameObject.GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		Debug.Log ("1");
		if (myBody.velocity.x < maxVel && myType == 0) {
			myBody.AddForce (new Vector3 (speed, 0, 0));
			//Debug.Log ("1");
		} else if (myBody.velocity.y < maxVel && myType == 1) {
			myBody.AddForce (new Vector3 (0, speed, 0));
			//Debug.Log ("2");
		} else if (myBody.velocity.z < maxVel && myType == 2) {
			myBody.AddForce (new Vector3 (0, 0, speed));
			//Debug.Log ("3");
		}
	}


}

using UnityEngine;
using System.Collections;

public class MAP : MonoBehaviour {
	public static MAP instance;
	private float vel;
	private float lastPositionX;
	private float timeStart = 0f;
	private float timeOut = 4f;
	// Use this for initialization
	void Awake () {
		vel = 5f;
		lastPositionX = 0f;
	}

	void Start(){
		instance = this;
	}

	public static float x(){
		if (instance == null)
			return 0;
		float x = instance.gameObject.transform.localPosition.x;
		return x;
	}

	public static float y(){
		if (instance == null)
			return 0;
		float y = instance.gameObject.transform.localPosition.y;
		return y;
	}

	public static float z(){
		if (instance == null)
			return 0;
		float z = instance.gameObject.transform.localPosition.z;
		return z;
	}

	// Update is called once per frame
	void Update () {
		float jumpingTo = -1 * Character.instance.jumpingTo;
		if (lastPositionX != jumpingTo) {
			Vector3 where = gameObject.transform.localPosition;
			if (Time.time - timeStart < timeOut) {
				if (where.x > jumpingTo) {
					where.x -= vel * Time.deltaTime;
				} else if (where.x < jumpingTo) {
					where.x += vel * Time.deltaTime;
				}
			} else {
				lastPositionX = jumpingTo;
				where.x = jumpingTo;
			}
			gameObject.transform.localPosition = where;
		} else {
			timeStart = Time.time;
		}
	}
}

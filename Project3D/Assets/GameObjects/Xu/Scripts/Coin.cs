using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {
	private Rigidbody myBody;
	private float jumpTime = 2f;
	private int alpha = 0;
	private int alphaSpeed = 3;
	private bool isGround;	
	private float jumpVel = 150f;
	void Awake(){
		isGround = false;
		myBody = gameObject.GetComponent<Rigidbody>();
	}
	// Use this for initialization
	void Start () {
		StartCoroutine (iEJump ());
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		alpha = alpha == 360 ? 0 : (alpha + alphaSpeed);
		myBody.transform.rotation = Quaternion.AngleAxis(alpha, Vector3.up);
	}
	
	public void jump(){
		if (isGround) {
			myBody.AddForce (new Vector3 (0, jumpVel, 0));
			isGround = false;
			jumpTime = Random.Range(2f, 5f);
		}
	}

	
	void OnCollisionEnter(Collision c){
		string tag = c.gameObject.tag;
		//Debug.Log (tag);
		switch (tag) {
		case "WalkGround":
			isGround = true;
			break;
		case "Character":
			Destroy(this.gameObject);
			break;
		}
	}

	IEnumerator iEJump(){
		yield return new WaitForSeconds(jumpTime);
		jump ();
		StartCoroutine (iEJump ());
	}
}

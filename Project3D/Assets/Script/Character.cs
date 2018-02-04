using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
	public static Character instance;
	private Rigidbody myBody;
	private float jumpVel = 250f;
	private float moveVel = .1f;
	private float vel = 3f;
	private float velJump = 3f;
	private float velRun = 5f;
	private float timeOut = .23f;
	private bool isGround;	
	public int indexGround;
	private bool isMoving;
	private float timeStartMove;

	void Awake(){
		instance = this;
		isGround = false;
		indexGround = 0;
		isMoving = false;
		myBody = gameObject.GetComponent<Rigidbody> ();
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Debug.Log (Time.time);
		Vector3 v3Position = myBody.transform.localPosition;
		v3Position.z += vel * Time.deltaTime;
		myBody.transform.localPosition = v3Position;
		move ();
	}
	
	public void moveLeft(){
		if (indexGround > -2) {
			timeStartMove = Time.time;
			isMoving = true;
			indexGround--;
		}
	}

	public void moveRight(){
		if (indexGround < 2) {
			timeStartMove = Time.time;
			isMoving = true;
			indexGround++;
		}
	}

	public void move(){	
		Vector3 v3Position = myBody.transform.localPosition;
		if (v3Position.x > indexGround) {//sang trai
			if(isMoving)
				v3Position.x -= moveVel;// * Time.deltaTime;
		} else if (v3Position.x < indexGround) {//sang phai			
			if(isMoving)
				v3Position.x += moveVel;// * Time.deltaTime;
		}

		if (Time.time - timeStartMove > timeOut) {
			v3Position.x = indexGround;
			isMoving = false;
		}

		myBody.transform.localPosition = v3Position;
	}
	
	public void jump(){
		if (isGround) {
			myBody.AddForce (new Vector3 (0, jumpVel, 0));
			isGround = false;
			vel = velJump;
		}
	}

	public void jumpPad(float super){
		if (isGround) {
			myBody.AddForce (new Vector3 (0, jumpVel * super, 0));
			isGround = false;
			vel = velJump;
		}
	}

	void OnCollisionEnter(Collision c){
		string tag = c.gameObject.tag;
		//Debug.Log (tag);
		switch (tag) {
		case "WalkGround":
			isGround = true;
			vel = velRun;
			break;
		case "JumpFail":
			Application.LoadLevel("MainMenu");
			break;
		}
	}

	void OnTriggerEnter(Collider c) {
		string tag = c.tag;
		if (c.tag.StartsWith ("JumpPad")) {
			float super = float.Parse(tag.Substring(7));
			jumpPad(super);
		}
	}

}	
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

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
	private Animator anim;
	[SerializeField]
	private bool started;
	private bool isAlive;

	void Awake(){
		instance = this;
		isGround = true;
		indexGround = 0;
		isMoving = false;
		started = false;
		isAlive = true;
		myBody = gameObject.GetComponent<Rigidbody> ();
		anim = gameObject.GetComponent<Animator> ();
	}
	// Use this for initialization
	void Start () {
	
	}

	public void begin(){
		this.started = true;
		anim.SetInteger ("status", 1);
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (started && isAlive) {
			//Debug.Log (Time.time);
			Vector3 v3Position = myBody.transform.localPosition;
			v3Position.z += vel * Time.deltaTime;
			myBody.transform.localPosition = v3Position;
			move ();
		}
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
			AudioManager.instance.jumpSound ();
			anim.SetInteger ("status", 2);
			myBody.AddForce (new Vector3 (0, jumpVel, 0));
			isGround = false;
			vel = velJump;
		}
	}

	public void jumpPad(float super){
		//if (isGround) {
			if(super < 2)
				AudioManager.instance.jumpSound ();
			else if(super < 4)
				AudioManager.instance.jump2Sound ();
			else if(super < 100)
				AudioManager.instance.jump5Sound ();
			anim.SetInteger ("status", 2);
			myBody.AddForce (new Vector3 (0, jumpVel * super, 0));
			isGround = false;
			vel = velJump;
		//}
	}

	private void death(){
		if (isAlive) {
			isAlive = false;
			anim.SetInteger ("status", 0);
			StartCoroutine(die ());
		}
	}

	IEnumerator die(){
		yield return new WaitForSeconds (2);
		SceneManager.LoadScene("MainMenu");
	}

	void OnCollisionEnter(Collision c){
		if (!started)
			return;
		string tag = c.gameObject.tag;//Debug.Log (tag);
		switch (tag) {
		case "WalkGround":
			isGround = true;
			vel = velRun;
			anim.SetInteger ("status", 1);
			break;
		case "JumpFail":
			AudioManager.instance.hitSound ();
			death ();
			break;
		case "Ramie":
			AudioManager.instance.hitSound ();
			death ();
			break;
		case "BlackGhost":
			AudioManager.instance.hitSound ();
			death ();
			break;
		case "Finish":
			AudioManager.instance.winSound ();
			GameManager.instance.finish ();
			anim.SetInteger ("status", 0);
			started = false;
			break;
		}
	}

	void OnTriggerEnter(Collider c) {
		if (!started)
			return;
		string tag = c.tag;
		if (c.tag.StartsWith ("JumpPad")) {
			float super = float.Parse(tag.Substring(7));
			jumpPad(super);
		}
	}

}	
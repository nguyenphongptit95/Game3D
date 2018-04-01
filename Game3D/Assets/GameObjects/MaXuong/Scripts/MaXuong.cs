using UnityEngine;
using System.Collections;

public class MaXuong : MonoBehaviour {

	Rigidbody myBody;
	Animator anim;
	float speed = 3f;
	float range = 3f;
	float rotate_ = 180f;
	bool rotating = false;
	float rotateSpeed_ = 18f;
	float start;
	float end;
	bool forward = false;
	float alpha = 180f;
	float forceY = 500f;
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
		myBody = gameObject.GetComponent<Rigidbody>();
		anim = gameObject.GetComponent<Animator>();
		Vector3 v3Position = myBody.transform.localPosition;
		start = v3Position.z - range;
		end = v3Position.z + range;
		MaXuongSpawner.add (this);
		hide ();
	}


	void Start(){
		myBody.AddForce (new Vector3 (0f, forceY, 0f));
	}

	void FixedUpdate () {
		Vector3 v3Position = myBody.transform.localPosition;
		if(rotating){	
			alpha+=rotateSpeed_;
			transform.rotation = Quaternion.AngleAxis(alpha, Vector3.up);
			if(alpha % 180 == 0){
				rotating = false;			
				v3Position.z += (forward ? .1f : -.1f);// * speed * Time.deltaTime;	
				myBody.transform.localPosition = v3Position;
			}
		} else if(v3Position.z < start){
			rotating = true;
			forward = true;		
		} else if(v3Position.z > end){
			rotating = true;
			forward = false;
		} else {	
			v3Position.z += (forward ? 1 : -1) * speed * Time.deltaTime;	
			myBody.transform.localPosition = v3Position;
		}

	}
}

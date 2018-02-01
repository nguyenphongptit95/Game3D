#pragma strict
var myBody: Rigidbody;

function Awake(){
	myBody = gameObject.GetComponent(Rigidbody);
}

function Start () {

}

function FixedUpdate () {
	var v3Position = myBody.transform.localPosition;
	v3Position.z += 2 * Time.deltaTime;
	myBody.transform.localPosition = v3Position;
}
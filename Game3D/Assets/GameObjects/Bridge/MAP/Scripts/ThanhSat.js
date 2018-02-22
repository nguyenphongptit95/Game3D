var relative : GameObject;
var relativeScript : ThanhSat;
var status = 0;
var moveUp = true;
var moveRight = true;
var vel = 5f;

function Awake(){

}

function setRelative(g : GameObject){
	relative = g;
}

function Start () {

}

function Update () {
	_moveUp();
	_moveRight();
}

function _moveUp(){
	if(status == 1){
		var v3Position = gameObject.transform.localPosition;
		if(relative != null){
			relativeScript = relative.GetComponent(ThanhSat);
			relativeScript.moveUp = !moveUp;	
			relativeScript.status = status;	
		}
		if(moveUp){
			v3Position.y += vel * Time.deltaTime;
		} else {	
			v3Position.y -= vel * Time.deltaTime;
		}
		
		gameObject.transform.localPosition = v3Position;	
	}
}

function _moveRight(){
	if(status == 2){
		var v3Position = gameObject.transform.localPosition;
		if(relative != null){
			relativeScript = relative.GetComponent(ThanhSat);
			relativeScript.moveRight = !moveRight;
			relativeScript.status = status;		
		}
		if(moveRight){
			v3Position.x -= vel * Time.deltaTime;
		} else {	
			v3Position.x += vel * Time.deltaTime;
		}
		
		gameObject.transform.localPosition = v3Position;	
	}
}

function OnCollisionEnter(c : Collision){
	if(c.gameObject.tag == "Girl"){
		status = 1;
		moveUp = false;
	}
}

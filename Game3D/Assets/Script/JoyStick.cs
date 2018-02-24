using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class JoyStick : MonoBehaviour,  IPointerDownHandler {
	void Start(){
		int w = Camera.main.pixelWidth;
		int h = Camera.main.pixelHeight;
		string tag = gameObject.tag;
		gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2 (w/10, w/10);
		switch (tag){
		case "LeftBtn":
			gameObject.GetComponent<RectTransform> ().position = new Vector3 (w / 7, h / 5, 0);
			break;
		case "RightBtn":
			gameObject.GetComponent<RectTransform> ().position = new Vector3 (w * 2/ 7, h /5, 0);
			break;

		case "JumpBtn":	
			gameObject.GetComponent<RectTransform> ().position = new Vector3 (w * 6 / 7, h / 5, 0);
			break;
		}
	}

	public void OnPointerDown(PointerEventData eventData){
		string tag = gameObject.tag;
		//Debug.Log (tag);
		switch (tag){
		case "LeftBtn":
			Character.instance.moveLeft();

			break;
		case "RightBtn":
			Character.instance.moveRight();
			break;

		case "JumpBtn":	
				Character.instance.jump();
			break;
		}
		
	}


}

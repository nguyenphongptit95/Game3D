using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class JoyStick : MonoBehaviour,  IPointerDownHandler {

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

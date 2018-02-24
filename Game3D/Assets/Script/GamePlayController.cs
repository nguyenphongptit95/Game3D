using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GamePlayController : MonoBehaviour {

	public void Start_(GameObject panel){
		panel.SetActive (false);
		string map = panel.gameObject.tag;
		if(map.Equals("map1")){
			Character.instance.setVel (5);
		}else if(map.Equals("map2")){
			Character.instance.setVel (7);
		}else{
			Character.instance.setVel (5);
		}
		Character.instance.begin ();
	}
}

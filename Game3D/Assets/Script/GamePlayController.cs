using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GamePlayController : MonoBehaviour {

	public void Start_(GameObject panel){
		panel.SetActive (false);
		string map = panel.gameObject.tag;
		if(map.Equals("map1")){
			Character.instance.setVel (5);
			Character.instance.setMaxX (2);
			Character.instance.setMinX (-2);
		}else if(map.Equals("map2")){
			Character.instance.setVel (7);
			Character.instance.setMaxX (2);
			Character.instance.setMinX (-2);
		}else if(map.Equals("map3")){
			Character.instance.setVel (10);
			Character.instance.setMaxX (30);
			Character.instance.setMinX (-30);
		}else{
			Character.instance.setVel (5);
		}
		Character.instance.begin ();
	}

	public void Pause_(){
		if(Time.timeScale!=0)
			Time.timeScale = 0;
		else
			Time.timeScale = 1;
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GamePlayController : MonoBehaviour {

	public void Start_(GameObject panel){
		panel.SetActive (false);
		Character.instance.begin ();
	}
}

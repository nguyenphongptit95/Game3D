using UnityEngine;
using System.Collections;

public class Key1 : MonoBehaviour {
	[SerializeField]
	private GameObject binderActive;
	[SerializeField]
	private GameObject binderInactive;
	void OnTriggerEnter(Collider c) {
		string tag = c.gameObject.tag;
		//Debug.Log (tag);
		switch (tag) {
		case "Character":
			binderActive.gameObject.SetActive (true);
			binderInactive.gameObject.SetActive (false);
			Destroy (gameObject);
			Destroy (this.gameObject);
			if(GameManager.instance != null)
				GameManager.instance.addScore ();
			break;
		}
	}
}

using UnityEngine;
using System.Collections;

public class JumpPadSpawner : MonoBehaviour {
	public static JumpPad[] listJump = new JumpPad[500];
	public static int size = 0;
	public static void reset(){
		listJump  = new JumpPad[500];
		size = 0;
	}

	void Start () {
		StartCoroutine (iEUp());
	}

	IEnumerator iEUp(){
		Vector3 chac = Character.instance.transform.localPosition;
		//Debug.Log (chac.z);
		for (int i = 0; i < size; i++) {
			if (listJump [i] != null) {
				Vector3 jump = listJump [i].transform.localPosition;
				if (chac.z - jump.z > 10) { // phia sau
					listJump [i].hide();
					//Debug.Log (1);
				}
				else if (jump.z - chac.z  < GameManager.seeFar) { // phia truoc
					listJump [i].appear();
					//Debug.Log (2);
				}
				else { // phia xa
					listJump [i].hide();
					//Debug.Log (3);
				}
			}
		}
		yield return new WaitForSeconds (GameManager.loopTimeOpt);
		StartCoroutine (iEUp());
	}


	public static void add(JumpPad c){
		listJump [size++] = c;
	}
}

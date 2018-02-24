using UnityEngine;
using System.Collections;

public class BlackGhostSpawner : MonoBehaviour {
	public static BlackGhost[] listGhost = new BlackGhost[500];
	public static int size = 0;
	public static void reset(){
		listGhost  = new BlackGhost[500];
		size = 0;
	}

	void Start () {
		StartCoroutine (iEUp());
	}

	IEnumerator iEUp(){
		Vector3 chac = Character.instance.transform.localPosition;
		//Debug.Log (chac.z);
		for (int i = 0; i < size; i++) {
			if (listGhost [i] != null) {
				Vector3 ghost = listGhost [i].transform.localPosition;
				/*if (Mathf.Abs (chac.x - ghost.x) > GameManager.seeWidth) {
					listGhost [i].hide();
					continue;
				}*/
				if (chac.z - ghost.z > 10) { // phia sau
					listGhost [i].hide();
					//Debug.Log (1);
				}
				else if (ghost.z - chac.z  < GameManager.seeFar) { // phia truoc
					listGhost [i].appear();
					//Debug.Log (2);
				}
				else { // phia xa
					listGhost [i].hide();
					//Debug.Log (3);
				}
			}
		}
		yield return new WaitForSeconds (GameManager.loopTimeOpt);
		StartCoroutine (iEUp());
	}

	public static void add(BlackGhost c){
		listGhost [size++] = c;
	}
}

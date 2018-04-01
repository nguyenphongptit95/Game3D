using UnityEngine;
using System.Collections;

public class GroundBlockSpawner : MonoBehaviour {
	public static GroundBlock[] listBlock = new GroundBlock[500];
	public static int size = 0;
	public static void reset(){
		listBlock  = new GroundBlock[500];
		size = 0;
	}
	// Update is called once per frame
	void Start () {
		StartCoroutine (iEUp());
	}

	IEnumerator iEUp(){
		Vector3 chac = Character.instance.transform.localPosition;
		//Debug.Log (chac.z);
		for (int i = 0; i < size; i++) {
			if (listBlock [i] != null) {
				Vector3 block = listBlock [i].transform.localPosition;

				if (Mathf.Abs (chac.x - block.x - MAP.x()) > GameManager.seeWidth) {
					listBlock [i].hide ();
					continue;
				}
				/*if (Mathf.Abs (chac.y - block.y - MAP.y()) > GameManager.seeHeight) {
					listBlock [i].hide ();
					continue;
				}*/


				if (chac.z - block.z > 12) { // phia sau
					listBlock [i].hide();
					//Debug.Log (1);
				}
				else if (block.z - chac.z  < GameManager.seeFar) { // phia truoc
					listBlock [i].appear();
					//Debug.Log (2);
				}
				else { // phia xa
					listBlock [i].hide();
					//Debug.Log (3);
				}
			}
		}
		yield return new WaitForSeconds (GameManager.loopTimeOpt);
		StartCoroutine (iEUp());
	}

	public static void add(GroundBlock c){
		listBlock [size++] = c;
	}
}

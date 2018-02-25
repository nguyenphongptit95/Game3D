using UnityEngine;
using System.Collections;

public class TruSpawner : MonoBehaviour {
	public static Tru[] listTru = new Tru[500];
	public static int size = 0;
	public static void reset(){
		listTru  = new Tru[500];
		size = 0;
	}

	void Start () {
		StartCoroutine (iEUp());
	}

	IEnumerator iEUp(){
		Vector3 chac = Character.instance.transform.localPosition;
		//Debug.Log (chac.z);
		for (int i = 0; i < size; i++) {
			if (listTru [i] != null) {
				Vector3 tru = listTru [i].transform.localPosition;
				if (Mathf.Abs (chac.x - tru.x - MAP.x()) > GameManager.seeWidth) {
					listTru [i].hide ();
					continue;
				}
				if (Mathf.Abs (chac.y - tru.y - MAP.y()) > GameManager.seeHeight) {
					listTru [i].hide ();
					continue;
				}

				if (chac.z - tru.z > 10) { // phia sau
					listTru [i].hide();
					//Debug.Log (1);
				}
				else if (tru.z - chac.z  < GameManager.seeFar) { // phia truoc
					listTru [i].appear();
					//Debug.Log (2);
				}
				else { // phia xa
					listTru [i].hide();
					//Debug.Log (3);
				}
			}
		}
		yield return new WaitForSeconds (GameManager.loopTimeOpt);
		StartCoroutine (iEUp());
	}


	public static void add(Tru c){
		listTru [size++] = c;
	}
}

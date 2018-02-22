using UnityEngine;
using System.Collections;

public class RamieSpawner : MonoBehaviour {
	public static Ramie[] listRamie = new Ramie[500];
	public static int size = 0;
	public static void reset(){
		listRamie  = new Ramie[500];
		size = 0;
	}

	void Start () {
		StartCoroutine (iEUp());
	}

	IEnumerator iEUp(){
		Vector3 chac = Character.instance.transform.localPosition;
		//Debug.Log (chac.z);
		for (int i = 0; i < size; i++) {
			if (listRamie [i] != null) {
				Vector3 ramie = listRamie [i].transform.localPosition;
				if (chac.z - ramie.z > 10) { // phia sau
					listRamie [i].hide();
					//Debug.Log (1);
				}
				else if (ramie.z - chac.z  < GameManager.seeFar) { // phia truoc
					listRamie [i].appear();
					//Debug.Log (2);
				}
				else { // phia xa
					listRamie [i].hide();
					//Debug.Log (3);
				}
			}
		}
		yield return new WaitForSeconds (GameManager.loopTimeOpt);
		StartCoroutine (iEUp());
	}


	public static void add(Ramie c){
		listRamie [size++] = c;
	}
}

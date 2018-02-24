using UnityEngine;
using System.Collections;

public class CoinSpawner : MonoBehaviour {
	public static Coin[] listCoin  = new Coin[500];
	public static int size = 0;

	public static void reset(){
		listCoin  = new Coin[500];
		size = 0;
	}

	void Start () {
		StartCoroutine (iEUp());
	}

	IEnumerator iEUp(){
		Vector3 chac = Character.instance.transform.localPosition;
		//Debug.Log (chac.z);
		for (int i = 0; i < size; i++) {
			if (listCoin [i] != null) {
				Vector3 coin = listCoin [i].transform.localPosition;
				/*if (Mathf.Abs (chac.x - coin.x) > GameManager.seeWidth) {
					listCoin [i].hide();
					continue;
				}*/
				if (chac.z - coin.z > 2) { // phia sau
					listCoin [i].hide();
					//Debug.Log (1);
				}
				else if (coin.z - chac.z  < GameManager.seeFar - 10) { // phia truoc
					listCoin [i].appear();
					//Debug.Log (2);
				}
				else { // phia xa
					listCoin [i].hide();
					//Debug.Log (3);
				}
			}
		}
		yield return new WaitForSeconds (GameManager.loopTimeOpt);
		StartCoroutine (iEUp());
	}


	public static void add(Coin c){
		listCoin [size++] = c;
	}
}

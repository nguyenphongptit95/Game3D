using UnityEngine;
using System.Collections;

public class StubBay : MonoBehaviour {

	[SerializeField]
	private int myType;
	[SerializeField]
	private GameObject sphere;
	[SerializeField]
	private GameObject ramie;
	[SerializeField]
	private GameObject block;
	[SerializeField]
	private GameObject maden;
	[SerializeField]
	private GameObject cot;
	[SerializeField]
	private GameObject them;
	[SerializeField]
	private GameObject ramieSwipe;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider c) {
		string tag = c.tag;
		if (c.tag.StartsWith ("Character")) {
			switch (myType) {
			case 0:
				sphere.gameObject.SetActive (true);
				break;
			case 1:
				ramie.gameObject.SetActive (true);
				break;
			case 2:
				block.gameObject.SetActive (true);
				break;
			case 3:
				maden.gameObject.SetActive (true);
				break;	
			case 4:
				cot.gameObject.SetActive (true);
				break;	
			case 5:
				them.gameObject.SetActive (true);
				break;	
			case 6:
				ramieSwipe.gameObject.SetActive (true);
				break;			
			}
		}
	}
}

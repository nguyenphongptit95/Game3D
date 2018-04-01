using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CanvasMainMenu : MonoBehaviour {
	[SerializeField]
	private Image box;
	[SerializeField]
	private Image logo;
	[SerializeField]
	private Button btnStart;
	[SerializeField]
	private Button btnStart2;
	[SerializeField]
	private Button btnQuit;
	// Use this for initialization
	int h, w;
	void Start () {
		w = Camera.main.pixelWidth;
		h = Camera.main.pixelHeight;
		Debug.Log (w);
		Debug.Log (h);
		//logo
		logo.GetComponent<RectTransform> ().localPosition = new Vector3 (0, h/3, 0);
		logo.GetComponent<RectTransform> ().sizeDelta = new Vector2 (w * 2 / 3, h * 2 / 6);

		// box
		box.GetComponent<RectTransform> ().localPosition = new Vector3 (0, -h/10, 0);
		box.GetComponent<RectTransform> ().sizeDelta = new Vector2 (w * 2 / 3, h * 4 / 6);

		//start
		btnStart.GetComponent<RectTransform> ().localPosition = new Vector3 ( w / 8.5f, - h / 10 , 0);
		btnStart.GetComponent<RectTransform> ().sizeDelta = new Vector2 (w  / 4, h / 6);

		//start2
		btnStart2.GetComponent<RectTransform> ().localPosition = new Vector3 ( - w / 8.5f,  - h / 10 , 0);
		btnStart2.GetComponent<RectTransform> ().sizeDelta = new Vector2 (w  / 4, h / 6);
		//quit
		btnQuit.GetComponent<RectTransform> ().localPosition = new Vector3 ( 0,  - h / 4 , 0);
		btnQuit.GetComponent<RectTransform> ().sizeDelta = new Vector2 (w  / 4, h / 6);
	}


}

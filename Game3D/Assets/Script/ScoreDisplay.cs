using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreDisplay : MonoBehaviour {
	private Text txtScore;
	[SerializeField]
	private GameObject panel;

	// Use this for initialization
	void Awake () {
		txtScore = GetComponent<Text> ();
	}

	void Start(){
		int w = Camera.main.pixelWidth;
		int h = Camera.main.pixelHeight;
		string tag = gameObject.tag;
		panel.gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2 (0, h/6);
	}

	// Update is called once per frame
	void Update () {
		if(GameManager.instance != null)
			txtScore.text = "Score: " + GameManager.instance.getScore(); 
	}
}

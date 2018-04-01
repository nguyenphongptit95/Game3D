using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndGameDisPlay : MonoBehaviour {
	[SerializeField]
	private Text txtScore;
	[SerializeField]
	private Text txtLife;
	[SerializeField]
	private Image imgLogo;
	[SerializeField]
	private Image imgContent;
	[SerializeField]
	private Button btnReStartOrNext;
	[SerializeField]
	private Button btnMainMenu;
	[SerializeField]
	private Image imgScore;
	[SerializeField]
	private Image imgLife;

	void Start () {
		int w = Camera.main.pixelWidth;
		int h = Camera.main.pixelHeight;
		//logo
		imgLogo.gameObject.GetComponent<RectTransform> ().localPosition = new Vector3 (0, h*.65f/2, 0);
		imgLogo.gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2 (w*2/3, h/3);
		if (GameManager.life == 0)
			imgLogo.gameObject.SetActive (true);


		//score and life

		imgScore.gameObject.GetComponent<RectTransform> ().localPosition = new Vector3 (-w/5, 0, 0);
		imgScore.gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2 (w/8, h/10);

		imgLife.gameObject.GetComponent<RectTransform> ().localPosition = new Vector3 (w/10, 0, 0);
		imgLife.gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2 (w/13, h/15);


		txtScore.gameObject.GetComponent<RectTransform> ().localPosition = new Vector3 (-w/20, 0, 0);
		txtScore.gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2 (w/6, h/3);
		if (GameManager.instance != null)
			txtScore.text = GameManager.instance.getScore () + "";
		
		txtLife.gameObject.GetComponent<RectTransform> ().localPosition = new Vector3 (w/ 5 , 0, 0);
		txtLife.gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2 (w/6, h/3);
		if (GameManager.instance != null)
			txtLife.text = GameManager.life + "";






		//panel
		imgContent.gameObject.GetComponent<RectTransform> ().localPosition = new Vector3 (0, - h/10, 0);
		imgContent.gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2 (w*4/5, h*4/5);
		//restart
		btnReStartOrNext.gameObject.GetComponent<RectTransform> ().localPosition = new Vector3 (0, - h/6, 0);
		btnReStartOrNext.gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2 (w/3, h/7);
		if (GameManager.life == 0)
			btnReStartOrNext.gameObject.SetActive (false);
		//restart
		btnMainMenu.gameObject.GetComponent<RectTransform> ().localPosition = new Vector3 (0, - h*2/6, 0);
		btnMainMenu.gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2 (w/3, h/7);
	}

}

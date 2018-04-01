using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {
	public static bool isSound = false;
	public static AudioManager instance;
	[SerializeField]
	private AudioSource audioSourceOneShot;
	[SerializeField]
	private AudioSource audioSourceBG;
	[SerializeField]
	private AudioClip coinS;
	[SerializeField]
	private AudioClip hitS;
	[SerializeField]
	private AudioClip jumpS;
	[SerializeField]
	private AudioClip jump2S;
	[SerializeField]
	private AudioClip jump5S;
	[SerializeField]
	private AudioClip winS;
	// Use this for initialization
	void Awake () {
		isSound = false;
		instance = this;
		if (!isSound)
			audioSourceBG.Stop ();
		//audioSourceOneShot = GetComponent<AudioSource> ();
	}

	public void coinSound(){
		if(isSound)
		audioSourceOneShot.PlayOneShot (coinS);
	}

	public void hitSound(){
		if(isSound)
		audioSourceOneShot.PlayOneShot (hitS);
	}

	public void jumpSound(){
		if(isSound)
		audioSourceOneShot.PlayOneShot (jumpS);
	}

	public void jump2Sound(){
		if(isSound)
		audioSourceOneShot.PlayOneShot (jump2S);
	}

	public void jump5Sound(){
		if(isSound)
		audioSourceOneShot.PlayOneShot (jump5S);
	}

	public void winSound(){
		if(isSound)
		audioSourceOneShot.PlayOneShot (winS);
	}

}

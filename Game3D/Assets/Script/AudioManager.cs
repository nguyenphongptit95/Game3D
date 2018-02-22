using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

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
		instance = this;
		audioSourceOneShot = GetComponent<AudioSource> ();
	}

	public void coinSound(){
		audioSourceOneShot.PlayOneShot (coinS);
	}

	public void hitSound(){
		audioSourceOneShot.PlayOneShot (hitS);
	}

	public void jumpSound(){
		audioSourceOneShot.PlayOneShot (jumpS);
	}

	public void jump2Sound(){
		audioSourceOneShot.PlayOneShot (jump2S);
	}

	public void jump5Sound(){
		audioSourceOneShot.PlayOneShot (jump5S);
	}

	public void winSound(){
		audioSourceOneShot.PlayOneShot (winS);
	}

}

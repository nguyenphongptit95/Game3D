using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

	public static AudioManager instance;
	private AudioSource audioSource;
	[SerializeField]
	private AudioClip coinS;
	[SerializeField]
	private AudioClip hitS;
	// Use this for initialization
	void Awake () {
		instance = this;
		audioSource = GetComponent<AudioSource> ();
	}

	public void coinSound(){
		audioSource.PlayOneShot (coinS);
	}

	public void hitSound(){
		audioSource.PlayOneShot (hitS);
	}
}

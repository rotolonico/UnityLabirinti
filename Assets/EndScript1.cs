using UnityEngine;
using System.Collections;

public class EndScript1 : MonoBehaviour {
	AudioSource WinSound;

	void Start () {
		WinSound = GetComponent<AudioSource>();		
	}

	void Awake() {
		DontDestroyOnLoad (transform.gameObject);
	}

	void OnTriggerEnter2D(Collider2D col) {
		string colliderName = col.gameObject.name;

		if (colliderName == "player") {
			WinSound.Play ();
			Application.LoadLevel (2);
		}
	}
}
using UnityEngine;
using System.Collections;

public class WallScript : MonoBehaviour {
	AudioSource ErrorSound;

	void Start () {
		ErrorSound = GetComponent<AudioSource>();		
	}


	void OnTriggerEnter2D(Collider2D col) {
		string colliderName = col.gameObject.name;

		if (colliderName == "player") {
			

		ErrorSound.Play ();

	}

	}
}
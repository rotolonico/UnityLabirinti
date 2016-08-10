using UnityEngine;
using System.Collections;

public class WallScript : MonoBehaviour {
	AudioSource ErrorSound;


	void OnTriggerEnter2D(Collider2D col) {
		string colliderName = col.gameObject.name;

		if (colliderName == "player") {
			

		//	ErrorSound.Play ();

	}

	}
}
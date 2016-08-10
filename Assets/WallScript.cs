using UnityEngine;
using System.Collections;

public class WallScript : MonoBehaviour {
	AudioSource ErrorSound;


	void OnTriggerEnter2D(Collider2D col) {
		string colliderName = col.gameObject.name;

		if (colliderName == "player") {
			

			ErrorSound.Play ();

		} else if (colliderName == "end") {
			Application.LoadLevel ("1");
		}
	}

	// Use this for initialization
	void Start () {
		ErrorSound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

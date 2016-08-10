using UnityEngine;
using System.Collections;

public class EndScript : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D col) {
		string colliderName = col.gameObject.name;

		if (colliderName == "player") {

		}
	}
}
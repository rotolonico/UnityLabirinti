using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	private AudioSource n;

	void OnTriggerEnter2D(Collider2D col) {
		string colliderTag = col.gameObject.tag;
		string colliderName = col.gameObject.name;

		if (colliderTag == "wall") {

			n.Play ();
			print ("Musica!");


		} else if (colliderName == "end") {
			Application.LoadLevel ("1");
		}
	}

	// Use this for initialization
	void Start () {
		n = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Input.GetAxis ("Horizontal") * Time.deltaTime * 4f, 0f, 0f, Space.World);
		transform.Translate (0f, Input.GetAxis ("Vertical") * Time.deltaTime * 4f, 0f, Space.World);
	}
}

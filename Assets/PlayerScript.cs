using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
		// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Input.GetAxis ("Horizontal") * Time.deltaTime * 8f, 0f, 0f, Space.World);
		transform.Translate (0f, Input.GetAxis ("Vertical") * Time.deltaTime * 8f, 0f, Space.World);
	}
}

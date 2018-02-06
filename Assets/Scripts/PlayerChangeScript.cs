using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChangeScript : MonoBehaviour {

	public GameObject Red;
	public GameObject Blue;
	public GameObject Yellow;
	public GameObject White;
	int count = 0;

	// Use this for initialization
	void Start () {
		Red.gameObject.SetActive (false);
		Blue.gameObject.SetActive (false);
		Yellow.gameObject.SetActive (false);
		White.gameObject.SetActive (true);

	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x >= -5.0f) {
			if (Input.GetKey (KeyCode.A)) {
				transform.position += new Vector3 (-0.5f, 0, 0);
			}
		}

		if(transform.position.x <= 5.0f){
			if (Input.GetKey (KeyCode.D)) {
				transform.position += new Vector3 (0.5f, 0, 0);
			}
		}

		if (Input.GetKeyDown (KeyCode.S)) {
			count++;
			if (count == 1) {
				Red.gameObject.SetActive (true);
				Blue.gameObject.SetActive (false);
				Yellow.gameObject.SetActive (false);
				White.gameObject.SetActive (false);
			}
			if (count == 2) {
				Red.gameObject.SetActive (false);
				Blue.gameObject.SetActive (true);
				Yellow.gameObject.SetActive (false);
				White.gameObject.SetActive (false);
			}
			if (count == 3) {
				Red.gameObject.SetActive (false);
				Blue.gameObject.SetActive (false);
				Yellow.gameObject.SetActive (true);
				White.gameObject.SetActive (false);
			}
			if (count == 4) {
				Red.gameObject.SetActive (false);
				Blue.gameObject.SetActive (false);
				Yellow.gameObject.SetActive (false);
				White.gameObject.SetActive (true);
				count = 0;
			}
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBlueScript : MonoBehaviour {

	public Camera mainCamera;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			Shot ();
		}
	}

	void Shot(){
		Vector3 center = new Vector3 (Screen.width / 2, Screen.height / 2, 0);
		Ray ray = mainCamera.ScreenPointToRay (center);
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, 100)) {
			if (hit.collider.GetComponent<MeshRenderer> ().material.color == Color.white) {

				hit.collider.GetComponent<MeshRenderer> ().material.color = Color.blue;
				hit.collider.gameObject.tag = "Blue";
			}
			if(hit.collider.GetComponent<MeshRenderer> ().material.color == Color.yellow) {
				Debug.DrawLine (Vector3.zero, new Vector3 (1, 0, 0), Color.yellow);
				hit.collider.GetComponent<MeshRenderer> ().material.color = Color.green;
				hit.collider.gameObject.tag = "Green";
			}
			if (hit.collider.GetComponent<MeshRenderer> ().material.color == Color.red) {
				Debug.DrawLine (Vector3.zero, new Vector3 (1, 0, 0), Color.yellow);
				hit.collider.GetComponent<MeshRenderer> ().material.color = Color.magenta;
				hit.collider.gameObject.tag = "Purple";
			}
		}
	}
}

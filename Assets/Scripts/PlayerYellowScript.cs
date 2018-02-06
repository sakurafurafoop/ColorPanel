using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerYellowScript : MonoBehaviour {

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

		//Rayが当たったら
		if (Physics.Raycast (ray, out hit, 100)) {
			//当たったものが白の状態なら黄色になる
			if (hit.collider.GetComponent<MeshRenderer> ().material.color == Color.white) {
				Debug.DrawLine (Vector3.zero, new Vector3 (1, 0, 0), Color.yellow);
				hit.collider.GetComponent<MeshRenderer> ().material.color = Color.yellow;
				hit.collider.gameObject.tag = "Yellow";
			}
			//当たったものが赤の状態ならオレンジになる
			if (hit.collider.GetComponent<MeshRenderer> ().material.color == Color.red) {
				Debug.DrawLine (Vector3.zero, new Vector3 (1, 0, 0), Color.yellow);
				hit.collider.GetComponent<MeshRenderer> ().material.color = new Color(255F/255F,165F/255F,0);
				hit.collider.gameObject.tag = "Orenge";
			}

			//当たったものが青の状態なら緑になる
			if(hit.collider.GetComponent<MeshRenderer> ().material.color == Color.blue) {
				Debug.DrawLine (Vector3.zero, new Vector3 (1, 0, 0), Color.yellow);
				hit.collider.GetComponent<MeshRenderer> ().material.color = Color.green;
				hit.collider.gameObject.tag = "Green";
			}
		}
	}
}

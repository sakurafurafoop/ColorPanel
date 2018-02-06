using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelDestroyScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DestroyPanel(){
		Destroy (this.gameObject,2.0f);
	}
}

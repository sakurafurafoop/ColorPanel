using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : GeneratorScript {

	public int score;
	public Text scoreText;
	/*GameObject one_score;
	GameObject two_score;
	GameObject three_score;*/
	public GameObject Score_UI;

	//GeneratorScript generatorScript;
	PanelDestroyScript paneldestroyScript;

	// Use this for initialization
	void Start () {
		/*one_score = generatorScript.one;
		two_score = generatorScript.two;
		three_score = generatorScript.three;*/
	}
	
	// Update is called once per frame
	void Update () {
		if (one.tag == two.tag && one.tag == three.tag) {
			if (one.tag == "Red") {
				score += 5;

			}
			if (one.tag == "Blue") {
				score += 5;
			}
			if (one.tag == "Yellow") {
				score += 5;
			}
			if (one.tag == "Orenge") {
				score += 10;
			}
			if (one.tag == "Purple") {
				score += 10;
			}
			if (one.tag == "Green") {
				score += 10;
			}
			scoreText.text = score.ToString ();
			PanelDestroyScript P1 = Score_UI.GetComponent<PanelDestroyScript> ();
			P1.DestroyPanel ();
		}
	}
}

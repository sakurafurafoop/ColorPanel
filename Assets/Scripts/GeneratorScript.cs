using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorScript : MonoBehaviour {

	public GameObject Panel_Red;
	public GameObject Panel_Blue;
	public GameObject Panel_Yellow;
	public GameObject Panel_Orenge;
	public GameObject Panel_Purple;
	public GameObject Panel_Green;
	public GameObject Panel_White;
	public GameObject one;
	public GameObject two;
	public GameObject three;
	float Timer;//時間をカウントする
	float Timing = 100.0f;//玉を落とすタイミング 5秒ごとに落とす
	float SortPanelA;
	float SortPanelB;
	float SortPanelC;

	// Use this for initialization
	void Start () {
		one = Instantiate (Panel_White, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
		Debug.Log ("one");
		two = Instantiate (Panel_White, new Vector3 (0, 0.7f, 0),transform.rotation);
		three =  Instantiate (Panel_Red, new Vector3 (6.0f, 0.7f, 0),transform.rotation);

	}
	
	// Update is called once per frame
	void Update () {
		/*Timer ++;//タイマーの値を毎秒増やす
		//PartarnA white&3color
		if (Timer > 0 && Timer <= 1000) {
			if (Timer % Timing == 0) {
				SortPanelA = Random.Range (0, 9.0f);
				if (SortPanelA <= 9.0f) {
					one = Instantiate (Panel_White, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
					Debug.Log ("one");
					two = Instantiate (Panel_White, new Vector3 (0, 0.7f, 0),transform.rotation);
					three =  Instantiate (Panel_Red, new Vector3 (6.0f, 0.7f, 0),transform.rotation);

				}
				/*if ((1.0f < SortPanelA) && (SortPanelA <= 2.0f)) {
					one = Instantiate (Panel_White, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
					two = Instantiate (Panel_White, new Vector3 (0, 0.7f, 0),transform.rotation);
					three = Instantiate (Panel_Yellow, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
				}
				if ((2.0f < SortPanelA) && (SortPanelA <= 3.0f)) {
					one = Instantiate (Panel_White, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
					two = Instantiate (Panel_White, new Vector3 (0, 0.7f, 0),transform.rotation);
					three = Instantiate (Panel_Blue, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
				}
				if ((3.0f < SortPanelA) && (SortPanelA <= 4.0f)) {
					one = Instantiate (Panel_White, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
					two = Instantiate (Panel_Red, new Vector3 (0, 0.7f, 0),transform.rotation);
					three = Instantiate (Panel_White, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
				}
				if ((4.0f < SortPanelA) && (SortPanelA <= 5.0f)) {
					one = Instantiate (Panel_White, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
					two = Instantiate (Panel_Yellow, new Vector3 (0, 0.7f, 0),transform.rotation);
					three = Instantiate (Panel_White, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
				}
				if ((5.0f < SortPanelA) && (SortPanelA <= 6.0f)) {
					one = Instantiate (Panel_White, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
					two = Instantiate (Panel_Blue, new Vector3 (0, 0.7f, 0),transform.rotation);
					three = Instantiate (Panel_White, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
				}
				if ((6.0f < SortPanelA) && (SortPanelA <= 7.0f)) {
					one = Instantiate (Panel_Red, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
					two = Instantiate (Panel_White, new Vector3 (0, 0.7f, 0),transform.rotation);
					three = Instantiate (Panel_White, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
				}
				if ((7.0f < SortPanelA) && (SortPanelA <= 8.0f)) {
					one = Instantiate (Panel_Yellow, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
					two = Instantiate (Panel_White, new Vector3 (0, 0.7f, 0),transform.rotation);
					three = Instantiate (Panel_White, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
				}
				if ((8.0f < SortPanelA) && (SortPanelA <= 9.0f)) {
					one = Instantiate (Panel_Blue, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
					two = Instantiate (Panel_White, new Vector3 (0, 0.7f, 0),transform.rotation);
					three = Instantiate (Panel_White, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
					}*/

			//}
		//}

		//PartarnB white&mixcolor
		/*if (Timer > 1000 && Timer <= 2000) {
			if (Timer % Timing == 0) {
				SortPanelB = Random.Range (0, 9.0f);
					if (SortPanelB <= 1.0f) {
						one =  Instantiate (Panel_White, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
						two = Instantiate (Panel_White, new Vector3 (0, 0.7f, 0),transform.rotation);
						three = Instantiate (Panel_Green, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
					}
					if ((1.0f < SortPanelB) && (SortPanelB <= 2.0f)) {
						one = Instantiate (Panel_White, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
						two = Instantiate (Panel_White, new Vector3 (0, 0.7f, 0),transform.rotation);
						three = Instantiate (Panel_Orenge, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
					}
					if ((2.0f < SortPanelB) && (SortPanelB <= 3.0f)) {
						one = Instantiate (Panel_White, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
						two = Instantiate (Panel_White, new Vector3 (0, 0.7f, 0),transform.rotation);
						three = Instantiate (Panel_Purple, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
					}
					if ((3.0f < SortPanelB) && (SortPanelB <= 4.0f)) {
						one = Instantiate (Panel_White, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
						two = Instantiate (Panel_Green, new Vector3 (0, 0.7f, 0),transform.rotation);
						three = Instantiate (Panel_White, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
					}
					if ((4.0f < SortPanelB) && (SortPanelB <= 5.0f)) {
						one = Instantiate (Panel_White, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
						two = Instantiate (Panel_Orenge, new Vector3 (0, 0.7f, 0),transform.rotation);
						three = Instantiate (Panel_White, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
					}
					if ((5.0f < SortPanelB) && (SortPanelB <= 6.0f)) {
						one = Instantiate (Panel_White, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
						two = Instantiate (Panel_Purple, new Vector3 (0, 0.7f, 0),transform.rotation);
						three = Instantiate (Panel_White, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
					}
					if ((6.0f < SortPanelB) && (SortPanelB <= 7.0f)) {
						one = Instantiate (Panel_Green, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
						two = Instantiate (Panel_White, new Vector3 (0, 0.7f, 0),transform.rotation);
						three = Instantiate (Panel_White, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
					}
					if ((7.0f < SortPanelB) && (SortPanelB <= 8.0f)) {
						one = Instantiate (Panel_Orenge, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
						two = Instantiate (Panel_White, new Vector3 (0, 0.7f, 0),transform.rotation);
						three = Instantiate (Panel_White, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
					}
					if ((8.0f < SortPanelB) && (SortPanelB <= 9.0f)) {
						one = Instantiate (Panel_Purple, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
						two = Instantiate (Panel_White, new Vector3 (0, 0.7f, 0),transform.rotation);
						three = Instantiate (Panel_White, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
					}
				}
		}


		//PartarnC white&3color&mixcolor
		if (Timer > 2000 && Timer <= 3000) {
				if (Timer % Timing == 0) {
					SortPanelC = Random.Range (0, 9.0f);
					if (SortPanelC <= 1.0f) {
						one = Instantiate (Panel_White, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
						two = Instantiate (Panel_Yellow, new Vector3 (0, 0.7f, 0),transform.rotation);
						three = Instantiate (Panel_Green, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
						}
					if ((1.0f < SortPanelC) && (SortPanelC <= 2.0f)) {
						one = Instantiate (Panel_Red, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
						two = Instantiate (Panel_White, new Vector3 (0, 0.7f, 0),transform.rotation);
						three = Instantiate (Panel_Orenge, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
						}
					if ((2.0f < SortPanelC) && (SortPanelC <= 3.0f)) {
						one = Instantiate (Panel_White, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
						two = Instantiate (Panel_Blue, new Vector3 (0, 0.7f, 0),transform.rotation);
						three = Instantiate (Panel_Purple, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
						}
					if ((3.0f < SortPanelC) && (SortPanelC <= 4.0f)) {
						one = Instantiate (Panel_Blue, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
						two = Instantiate (Panel_Green, new Vector3 (0, 0.7f, 0),transform.rotation);
						three = Instantiate (Panel_White, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
						}
					if ((4.0f < SortPanelC) && (SortPanelC <= 5.0f)) {
						one = Instantiate (Panel_White, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
						two = Instantiate (Panel_Orenge, new Vector3 (0, 0.7f, 0),transform.rotation);
						three = Instantiate (Panel_Yellow, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
						}
					if ((5.0f < SortPanelC) && (SortPanelC <= 6.0f)) {
						one = Instantiate (Panel_Red, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
						two = Instantiate (Panel_Purple, new Vector3 (0, 0.7f, 0),transform.rotation);
						three = Instantiate (Panel_White, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
						}
					if ((6.0f < SortPanelC) && (SortPanelC <= 7.0f)) {
						one = Instantiate (Panel_Green, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
						two = Instantiate (Panel_Blue, new Vector3 (0, 0.7f, 0),transform.rotation);
						three = Instantiate (Panel_Yellow, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
						}
						if ((7.0f < SortPanelC) && (SortPanelC <= 8.0f)) {
						one = Instantiate (Panel_Orenge, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
						two = Instantiate (Panel_Red, new Vector3 (0, 0.7f, 0),transform.rotation);
						three = Instantiate (Panel_Yellow, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
						}
						if ((8.0f < SortPanelC) && (SortPanelC <= 9.0f)) {
						one = Instantiate (Panel_Purple, new Vector3 (-6.0f, 0.7f, 0),transform.rotation);
						two = Instantiate (Panel_Red, new Vector3 (0, 0.7f, 0),transform.rotation);
						three = Instantiate (Panel_Blue, new Vector3 (6.0f, 0.7f, 0),transform.rotation);
						}
					}
			}*/
}


}



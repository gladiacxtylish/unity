using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("Welcome");


	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("uuu");
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			print ("wwww");
		}
	}
}

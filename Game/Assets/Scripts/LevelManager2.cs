using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelManager2 : MonoBehaviour {

	public Text text;
	private 

	// Use this for initialization
	void Start () {
		this.text.text = "00000";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void addPoints(int points) {

	}

	public void LoadLevel (string name) {
		Application.LoadLevel (name);
	}
}

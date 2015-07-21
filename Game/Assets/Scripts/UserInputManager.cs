using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UserInputManager : MonoBehaviour {

	char[] answer;

	public Text one;
	public Text two;
	public Text three;
	private Text[] texts;

	// Use this for initialization
	void Start () {
		answer = new char[3] {'d', 'o', 'g'};
		texts = new Text[3] {one, two, three};
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Test (char input) {
		print ("!!!");

		for (int i = 0; i < answer.Length; i++) {
			if (input == answer[i]) {
				texts[i].text = input.ToString();
			}
		}
	}
}

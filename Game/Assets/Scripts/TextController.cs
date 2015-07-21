using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;

	// Use this for initialization
	void Start () {
		text.text = "test";
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.A)) {
			text.text = "dfsjlsjdflkjjskd lsdkfj lsjfd lsdjf ljfsd ljls klfkdsj jf lsdkj flsdj ljf lksdjf ksjd lfksdjfl sdjfoiwejfwiojfeiwjffffffijo fsjp jfpsdjfop jsdpfo jefiow jjefiw pijo";
		}
	}
}

using UnityEngine;
using System.Collections;

public class Characters : MonoBehaviour {

	GameObject go;
	UserInputManager other;


	// Use this for initialization
	void Start () {
		go = GameObject.Find("UserInputManager");
		print (go);
		other = (UserInputManager) go.GetComponent(typeof(UserInputManager));

	}
	
	// Update is called once per frame
	void Update () {


	    if (Input.GetKeyDown (KeyCode.A)) {
			print ("A");
			char a = 'a';
			other.Test(a);
		} else if (Input.GetKeyDown (KeyCode.B)) {
			print ("B");
			other.Test('b');
		}
	    else if (Input.GetKeyDown (KeyCode.C)) {
		    print ("O");
		    other.Test('c');
	    }
		else if (Input.GetKeyDown (KeyCode.D)) {
			print ("O");
			other.Test('d');
		}
		else if (Input.GetKeyDown (KeyCode.O)) {
			print ("O");
			other.Test('o');
		}
		else if (Input.GetKeyDown (KeyCode.G)) {
			print ("G");
			other.Test('g');
		}
	}


}

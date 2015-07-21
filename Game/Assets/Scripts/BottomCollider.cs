using UnityEngine;
using System.Collections;

public class BottomCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 v = new Vector3 (50f, this.transform.position.y, 0f);
		v.x = Input.mousePosition.x / Screen.width * 15;
		this.transform.position = v;
	}

	void OnTriggerEnter2D (Collider2D trigger) {
		print ("0000000000000000000");
	}

	void OnCollisionEnter2D (Collision2D trigger) {
		print ("111111111111111111111111");
	}
}

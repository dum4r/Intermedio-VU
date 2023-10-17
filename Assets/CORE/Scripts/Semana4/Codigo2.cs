using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Codigo2 : MonoBehaviour {
	void Start(){
		transform.position = new Vector3(20,5,0);
		Debug.Log(gameObject.name);
	}
	// void Awake() {
	// 	transform.position = new Vector3(20,5,0);
	// 	Debug.Log(gameObject.name);
	// 	// Destroy(gameObject);
	// }
}

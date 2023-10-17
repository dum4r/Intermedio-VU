using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Codigo1 : MonoBehaviour {
	public GameObject Obj2x;

	void Start(){
		transform.position = Obj2x.transform.position;
		Debug.Log(gameObject.name);
	}
}

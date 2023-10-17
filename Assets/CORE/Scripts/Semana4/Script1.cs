using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screipt1 : MonoBehaviour {
	public int contador;
	private Rigidbody2D rb;

	void Start(){
		// Debug.Log(contador++);
		rb = GetComponent<Rigidbody2D>();

	}
	void Update(){
		Debug.Log(contador++);
	}
}

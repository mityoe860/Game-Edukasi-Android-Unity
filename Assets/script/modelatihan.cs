﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelatihan : MonoBehaviour {
float x,y;
	// Use this for initialization
	void Start () {
			x = transform.localScale.x;
		y = transform.localScale.y;
	}
	void OnMouseDown(){
		GetComponent<AudioSource> ().Play ();
		transform.localScale = new Vector2 (x*1.1f, y/1.1f);
	}
	void OnMouseUp(){
		transform.localScale = new Vector2 (x,y);
		Application.LoadLevel ("modelatihan");
	}
	// Update is called once per frame
	void Update () {
		
	}
}

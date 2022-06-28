using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class latihan_pengurangan : MonoBehaviour
{
   float x,y;

	// Use this for initialization
	void Start () {
		x = transform.localScale.x;
		y = transform.localScale.y;
	}
	void OnMouseDown(){
		GetComponent<AudioSource> ().Play ();
		transform.localScale = new Vector2 (x*1.2f, y/1.2f);
		
	}
	
	void OnMouseUp(){
		transform.localScale = new Vector2 (x,y);
		Application.LoadLevel ("latihan_pengurangan");
	}
	// Update is called once per frame
	void Update () {
		
	}
}

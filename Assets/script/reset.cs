using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour {
public GameObject parent_puzzle, karakter_1;
float x,y;
	// Use this for initialization
	void Start () {
		x = transform.localScale.x;
		y = transform.localScale.y;
	}
	void OnMouseDown(){
		GetComponent<AudioSource> ().Play ();
		transform.localScale = new Vector2 (x*1.2f, y/1.2f);}

	void OnMouseUp(){
		transform.localScale = new Vector2 (x,y);
		for (int i = 0; i < 4; i++){
		parent_puzzle.transform.GetChild (i).GetComponent<drag> ().on_tempel = false;
		parent_puzzle.transform.GetChild (i).GetComponent<drag> ().on_pos = false;
		parent_puzzle.transform.GetChild (i).position = parent_puzzle.transform.GetChild (i).GetComponent<drag> ().pos_awal;
		parent_puzzle.transform.GetChild (i).localScale = parent_puzzle.transform.GetChild (i).GetComponent<drag> ().scale_awal;
		}
			karakter_1.SetActive (false);
			parent_puzzle.GetComponent<feed>().selesai = false;
			
	}
	// Update is called once per frame
	void Update () {
		
	}
}

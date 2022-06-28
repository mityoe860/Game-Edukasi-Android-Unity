using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlpuzzle : MonoBehaviour {
public GameObject parent;
float x,y;
	// Use this for initialization
	void Start () {
		x = transform.localScale.x;
		y = transform.localScale.y;
	}
	int urutan = 0;

	void aktif(int a){
urutan+=a;
if(urutan <0) {
	urutan = parent.transform.childCount -1;
} else if (urutan > parent.transform.childCount-1) {
	urutan  = 0;
} for (int i = 0; i < parent.transform.childCount; i++){
	parent.transform.GetChild(i).gameObject.SetActive (false);
} parent.transform.GetChild (urutan).gameObject.SetActive(true);
	}

void OnMouseDown(){
		GetComponent<AudioSource> ().Play ();
		transform.localScale = new Vector2 (x*1.2f, y/1.2f);}

	void OnMouseUp(){
		transform.localScale = new Vector2 (x,y);
		if (gameObject.name == "next"){
			aktif(1);
		} else {
			aktif (-1);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}

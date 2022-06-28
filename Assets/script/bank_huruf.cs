using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bank_huruf : MonoBehaviour {
	int urutan = 0;
	// Use this for initialization
	void Start () {
		setActive ();
	}
	
	public void control(int i){
		urutan += i;
		if(urutan > transform.childCount-1) {
			urutan = 0;
		} else if(urutan<0){
			urutan = transform.childCount - 1;
		}
		setActive();
	}
	public void setActive(){
			for (int i = 0; i < transform.childCount; i++) {
					transform.GetChild (i).gameObject.SetActive (false);
			} 
			transform.GetChild (urutan).gameObject.SetActive (true);
	}
	// Update is called once per frame
	void Update () {
		
	}
}

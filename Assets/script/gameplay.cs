using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameplay : MonoBehaviour {
	public string[] soal;
	public string[] jawaban;

	public Text text_soal, text_skor;
	public InputField input_jawaban;

	public GameObject feed_benar, feed_salah, selesai;

	int nomor_soal = -1, skor = 0;

	// Use this for initialization
	void Start () {
		buka_soal ();
	}

	void buka_soal(){

		nomor_soal++;
		text_soal.text = soal [nomor_soal];
	}

	public void jawab(){

		if (nomor_soal < soal.Length-1) {
			if (input_jawaban.text == jawaban [nomor_soal]) {
				feed_benar.SetActive (false);
				feed_benar.SetActive (true);
				feed_salah.SetActive (false);
				skor += 20;
			} else {
				feed_benar.SetActive (false);
				feed_salah.SetActive (false);
				feed_salah.SetActive (true);
			}
			buka_soal ();
			input_jawaban.text = "";
		} else {
			if(input_jawaban.text == jawaban [nomor_soal]) {
				skor += 20; }
			selesai.SetActive (true);
			transform.GetChild(transform.childCount-1).gameObject.SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		text_skor.text = skor.ToString ();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jawab : MonoBehaviour
{
	
public GameObject feed_benar, feed_salah;
    // Start is called before the first frame update
    void Start()
    {
        
    }

public void jawaban(bool jawab){
       if (jawab) {
         feed_benar.SetActive (false);
		 feed_benar.SetActive (true);
		skor.scoreValue += 10;
		if (skor.scoreValue > PlayerPrefs.GetInt("highscore") ) {
		PlayerPrefs.SetInt("highscore", skor.scoreValue);}
		
    } else {
          feed_salah.SetActive (false);
		  feed_salah.SetActive (true);
		 skor.scoreValue -= 10;
if (skor.scoreValue < PlayerPrefs.GetInt("highscore")) {
		PlayerPrefs.SetInt("highscore", skor.scoreValue);}
		 
}
gameObject.SetActive (false);
             }
			 
    // Update is called once per frame
    void Update()
    {
         
    }
}

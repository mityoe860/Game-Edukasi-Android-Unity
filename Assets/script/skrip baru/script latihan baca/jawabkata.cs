using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jawabkata : MonoBehaviour
{
	
public GameObject feed_benar, feed_salah;
    // Start is called before the first frame update
    void Start()
    {
        
    }

public void jawabankata(bool jawabkata){
       if (jawabkata) {
         feed_benar.SetActive (false);
		 feed_benar.SetActive (true);
		skorkata.scoreValue += 10;
		if (skorkata.scoreValue > PlayerPrefs.GetInt("highscorekata") ) {
		PlayerPrefs.SetInt("highscorekata", skorkata.scoreValue);}
		
    } else {
          feed_salah.SetActive (false);
		  feed_salah.SetActive (true);
		 skorkata.scoreValue -= 10;
if (skorkata.scoreValue < PlayerPrefs.GetInt("highscorekata")) {
		PlayerPrefs.SetInt("highscorekata", skorkata.scoreValue);}
		 
}
gameObject.SetActive (false);
             }
			 
    // Update is called once per frame
    void Update()
    {
         
    }
}

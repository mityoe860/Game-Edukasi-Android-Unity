using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jawabhitung : MonoBehaviour
{
	
public GameObject feed_benar, feed_salah;
    // Start is called before the first frame update
    void Start()
    {
        
    }

public void jawabanhitung(bool jawabhitung){
       if (jawabhitung) {
         feed_benar.SetActive (false);
		 feed_benar.SetActive (true);
		skorhitung.scoreValue += 10;
		if (skorhitung.scoreValue > PlayerPrefs.GetInt("highscorehitung") ) {
		PlayerPrefs.SetInt("highscorehitung", skorhitung.scoreValue);}
		
    } else {
          feed_salah.SetActive (false);
		  feed_salah.SetActive (true);
		 skorhitung.scoreValue -= 10;
if (skorhitung.scoreValue < PlayerPrefs.GetInt("highscorehitung")) {
		PlayerPrefs.SetInt("highscorehitung", skorhitung.scoreValue);}
		 
}
gameObject.SetActive (false);
             }
			 
    // Update is called once per frame
    void Update()
    {
         
    }
}

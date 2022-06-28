using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class skorkata1 : MonoBehaviour
{
public Text HStextkata;
    // Start is called before the first frame update
public void resetHSkata() {
	PlayerPrefs.SetInt("highscorekata", 0);
	HStextkata.text = "High Score : " + 0;
}
    void Start()
    {
		
   HStextkata.text = "High Score : " + PlayerPrefs.GetInt("highscorekata");
    }

    // Update is called once per frame
    void Update()
    { 
	
      GetComponent<Text> ().text = PlayerPrefs.GetInt ("highscorekata").ToString();

    }
}

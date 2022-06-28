using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class skor1 : MonoBehaviour
{
public Text HStext;
    // Start is called before the first frame update
public void resetHS() {
	PlayerPrefs.SetInt("highscore", 0);
	HStext.text = "High Score : " + 0;
}
    void Start()
    {
		
   HStext.text = "High Score : " + PlayerPrefs.GetInt("highscore");
    }

    // Update is called once per frame
    void Update()
    { 
	
      GetComponent<Text> ().text = PlayerPrefs.GetInt ("highscore").ToString();

    }
}

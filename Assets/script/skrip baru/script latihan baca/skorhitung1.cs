using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class skorhitung1 : MonoBehaviour
{
public Text HStexthitung;
    // Start is called before the first frame update
public void resetHShitung() {
	PlayerPrefs.SetInt("highscorehitung", 0);
	HStexthitung.text = "High Score : " + 0;
}
    void Start()
    {
		
   HStexthitung.text = "High Score : " + PlayerPrefs.GetInt("highscorehitung");
    }

    // Update is called once per frame
    void Update()
    { 
	
      GetComponent<Text> ().text = PlayerPrefs.GetInt ("highscorehitung").ToString();

    }
}
